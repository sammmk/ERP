using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManage.CLL
{
    public partial class FrmEditStockIntake : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;
        //private static int SEARCHTYPE;
        private static string SEARCH;

        public FrmEditStockIntake()
        {
            InitializeComponent();
        }

        public FrmEditStockIntake(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            USERNAME = userName;
            //SEARCHTYPE = 1;
            SEARCH = string.Empty;

            InitializeComponent();

            fillGrid(SEARCH);
        }

        private void fillGrid(string str)
        {
            try
            {
                //clear the gridview if there are any rows
                grd_editStockEntry.DataSource = null;
                grd_editStockEntry.Refresh();

                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.DataPropertyName = "stockEntryId";
                col.Name = "stockEntryId";
                col.HeaderText = "Stock Entry Id";
                grd_editStockEntry.Columns.Add(col);
                grd_editStockEntry.DataSource = MANAGEDB.getStockDetails(str);

                //arrange the gridview
                grd_editStockEntry.Columns["stockEntryId"].DisplayIndex = 0;
                grd_editStockEntry.Columns["itemCode"].DisplayIndex = 1;
                grd_editStockEntry.Columns["itemName"].DisplayIndex = 2;
                grd_editStockEntry.Columns["quantity"].DisplayIndex = 3;
                grd_editStockEntry.Columns["remainQuantity"].DisplayIndex = 4;
                grd_editStockEntry.Columns["buyingUnitPrice"].DisplayIndex = 5;
                grd_editStockEntry.Columns["totalValue"].DisplayIndex = 6;
                grd_editStockEntry.Columns["sellingUnitPrice"].DisplayIndex = 7;
                grd_editStockEntry.Columns["createDate"].DisplayIndex = 8;
                grd_editStockEntry.Columns["updateDate"].DisplayIndex = 9;
                grd_editStockEntry.Columns["stockEntryDate"].DisplayIndex = 10;
                grd_editStockEntry.Columns["expirationDate"].DisplayIndex = 11;

                grd_editStockEntry.Columns["updateDate"].Visible = false;
                grd_editStockEntry.Columns["stockEntryDate"].Visible = false;
                grd_editStockEntry.Columns["expirationDate"].Visible = false;
                grd_editStockEntry.Columns["itemId"].Visible = false;
                grd_editStockEntry.Columns["priceAfterDiscount"].Visible = false;
                grd_editStockEntry.Columns["comment"].Visible = false;
                grd_editStockEntry.Columns["releaseFlg"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmEditStockIntake_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editStockEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int stockEctryId = 0;
            BLL.ClsStockData stockData = new BLL.ClsStockData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        stockEctryId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        stockData = MANAGEDB.getSingleStockDetail(stockEctryId);

                        FrmAdjustStock frmUser = new FrmAdjustStock(stockData, USERNAME);
                        frmUser.WindowState = FormWindowState.Normal;
                        frmUser.ShowDialog();
                        fillGrid(SEARCH);
                        //grd_editStockEntry.DataSource = MANAGEDB.getStockDetails(SEARCHTYPE);
                    }
                }
                else
                {
                    COM_MESSAGE.permissionMessage("Sorry You dont have permission to do action !!!");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string str = String.Empty;

                if (chk_all.Checked)
                {
                    SEARCH = String.Empty;
                }
                else if (chk_date.Checked)
                {
                    SEARCH = string.Concat(" AND s.stockEntryDate BETWEEN '", dt_from.Value.Date.ToString("yyyy/MM/dd"), "' AND '",dt_to.Value.Date.ToString("yyyy/MM/dd"), "' ");
                }
                else if (chk_itemCode.Checked)
                {
                    if (!string.IsNullOrEmpty(txt_itemCode.Text))
                    {
                        SEARCH = string.Concat(" AND s.itemCode = ", txt_itemCode.Text);
                    }
                    else
                    {
                        COM_MESSAGE.validationMessage("Item Code Cannot be Empty !!!");
                    }            
                }
                else
                {
                    SEARCH = String.Empty;
                }

                fillGrid(SEARCH);
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_all.Checked)
            { 
                chk_date.Enabled = false;
                dt_from.Enabled = false;
                dt_to.Enabled = false;
                chk_itemCode.Enabled = false;
                txt_itemCode.Enabled = false;
            }
            else
            {
                chk_date.Enabled = true;
                dt_from.Enabled = true;
                dt_to.Enabled = true;
                chk_itemCode.Enabled = true;
                txt_itemCode.Enabled = true;
            }
        }

        private void chk_date_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_date.Checked)
            {
                chk_all.Enabled = false;
                dt_from.Enabled = true;
                dt_to.Enabled = true;
                chk_itemCode.Enabled = true;
                txt_itemCode.Enabled = false;
            }
            else
            {
                chk_all.Enabled = true;
                chk_itemCode.Enabled = true;
                txt_itemCode.Enabled = true;
            }
        }

        private void chk_itemCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_itemCode.Checked)
            {
                chk_all.Enabled = false;
                chk_date.Enabled = true;
                dt_from.Enabled = true;
                dt_to.Enabled = true;
                txt_itemCode.Enabled = true;
            }
            else
            {
                chk_all.Enabled = true;
                chk_date.Enabled = true;
                dt_from.Enabled = true;
                dt_to.Enabled = true;
                txt_itemCode.Enabled = true;
            }
        }

        private void txt_itemCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = new DataTable();

                    //get item data and fill data
                    dt = MANAGEDB.getItemDataForStockEntry(txt_itemCode.Text);

                    if (dt.Rows.Count >= 1)
                    {
                        //System.Media.SystemSounds.Beep.Play();
                        //System.Media.SystemSounds.Asterisk.Play();
                        //System.Media.SystemSounds.Exclamation.Play();
                        //System.Media.SystemSounds.Question.Play();
                        //System.Media.SystemSounds.Hand.Play();
                        btn_search.PerformClick();
                    }
                    else
                    {
                        COM_MESSAGE.warningMessage("The Item you are searching is not found", "Not Found");
                        txt_itemCode.Clear();
                        txt_itemCode.Focus();
                        //System.Media.SystemSounds.Beep.Play();
                        //System.Media.SystemSounds.Asterisk.Play();
                        //System.Media.SystemSounds.Exclamation.Play();
                        //System.Media.SystemSounds.Question.Play();
                        //System.Media.SystemSounds.Hand.Play();
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_itemCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_itemCode.Text))
                {
                    DataTable dt = new DataTable();

                    //get item data and fill data
                    dt = MANAGEDB.getItemDataForStockEntry(txt_itemCode.Text);

                    if (dt.Rows.Count >= 1)
                    {
                        //System.Media.SystemSounds.Beep.Play();
                        //System.Media.SystemSounds.Asterisk.Play();
                        //System.Media.SystemSounds.Exclamation.Play();
                        //System.Media.SystemSounds.Question.Play();
                        //System.Media.SystemSounds.Hand.Play();
                    }
                    else
                    {
                        COM_MESSAGE.warningMessage("The Item you are searching is not found", "Not Found");
                        txt_itemCode.Clear();
                        txt_itemCode.Focus();
                        //System.Media.SystemSounds.Beep.Play();
                        //System.Media.SystemSounds.Asterisk.Play();
                        //System.Media.SystemSounds.Exclamation.Play();
                        //System.Media.SystemSounds.Question.Play();
                        //System.Media.SystemSounds.Hand.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
