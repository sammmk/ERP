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
    public partial class FrmSelectStockEntry : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;
        public string StockEntryId { get; set; }
        public double InStockQty { get; set; }
        public double UnitPrice { get; set; }
        public double StockIdQty { get; set; }

        private List<string> STOCK_ID_LIST = new List<string>();

        public FrmSelectStockEntry()
        {
            InitializeComponent();
        }

        public FrmSelectStockEntry(string userName, string itemCode, string releaseQty, string stockIdQty, List<string> StockIdList)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            USERNAME = userName;

            InitializeComponent();
            STOCK_ID_LIST = StockIdList;

            fillData(itemCode, releaseQty, stockIdQty);
        }

        private void fillData(string itemCode, string releaseQty, string stockIdQty)
        {
            try
            {
                DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
                select.DataPropertyName = "select";
                select.Name = "select";
                select.HeaderText = "Select";
                select.TrueValue = true;
                select.FalseValue = false;
                grd_selectStockEntry.Columns.Add(select);

                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.DataPropertyName = "stockEntryId";
                col.Name = "stockEntryId";
                col.HeaderText = "Stock Id";
                grd_selectStockEntry.Columns.Add(col);

                grd_selectStockEntry.DataSource = MANAGEDB.getStockEntryDetailsForItem(itemCode);
                grd_selectStockEntry.Columns["itemName"].ReadOnly = true;
                grd_selectStockEntry.Columns["itemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grd_selectStockEntry.Columns["itemCode"].ReadOnly = true;
                grd_selectStockEntry.Columns["remainQuantity"].ReadOnly = true;
                grd_selectStockEntry.Columns["sellingUnitPrice"].ReadOnly = true;

                grd_selectStockEntry.Columns["stockEntryId"].DisplayIndex = 0;
                grd_selectStockEntry.Columns["itemName"].DisplayIndex = 1;
                grd_selectStockEntry.Columns["itemCode"].DisplayIndex = 2;
                grd_selectStockEntry.Columns["remainQuantity"].DisplayIndex = 3;
                grd_selectStockEntry.Columns["sellingUnitPrice"].DisplayIndex = 4;
                grd_selectStockEntry.Columns["select"].DisplayIndex = 5;

                lbl_totalQty.Text = MANAGEDB.getTotalStockAmountForItem(itemCode).ToString();
                lbl_releaseQty.Text = releaseQty;
                lbl_shortage.Text = (!string.IsNullOrEmpty(releaseQty)) ? (Convert.ToDouble(stockIdQty) - Convert.ToDouble(releaseQty)).ToString() : 0.ToString();
                //grd_selectStockEntry.Columns["QTY"].Visible = false;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void grd_selectStockEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            try
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    StockEntryId = senderGrid.SelectedCells[e.ColumnIndex - 1].Value.ToString();
                    //InStockQty = Convert.ToDouble(lbl_totalQty.Text);
                    //UnitPrice = (!string.IsNullOrEmpty(senderGrid.Rows[e.RowIndex].Cells["sellingUnitPrice"].Value.ToString())) ? Convert.ToDouble(senderGrid.Rows[e.RowIndex].Cells["sellingUnitPrice"].Value) : 0;
                    //StockIdQty = Convert.ToDouble(senderGrid.Rows[e.RowIndex].Cells["remainQuantity"].Value);
                    this.Close();
                }

                if(senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                {
                    if((bool)senderGrid.Rows[e.RowIndex].Cells["select"].Value)
                    {
                        //occur when checked
                        grd_selectStockEntry.Rows[e.RowIndex].Cells["select"].Value = false;
                    }
                    else
                    {
                        //occur when unchecked
                        grd_selectStockEntry.Rows[e.RowIndex].Cells["select"].Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void grd_selectStockEntry_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grd_selectStockEntry.Rows)
                {
                    row.Cells["select"].Value = false;
                }

                foreach (string id in STOCK_ID_LIST)
                {
                    foreach (DataGridViewRow row in grd_selectStockEntry.Rows)
                    {
                        if (row.Cells["stockEntryId"].Value.ToString() == id)
                        {
                            row.Cells["select"].Value = true;
                            break;
                        }
                    }
                }

                //check the first row checkbox checked
                grd_selectStockEntry.Rows[0].Cells["select"].Value = true;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmSelectStockEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int count = 0;
                string tmp = string.Empty;

                foreach (DataGridViewRow row in grd_selectStockEntry.Rows)
                {
                    if(Convert.ToBoolean(row.Cells["select"].Value) == true)
                    {
                        StockEntryId = row.Cells["stockEntryId"].Value.ToString();
                        count++;
                    }
                }

                if(count > 1)
                {
                    StockEntryId = "Multiple";                    
                }

                InStockQty = Convert.ToDouble(lbl_totalQty.Text);
                UnitPrice = (!string.IsNullOrEmpty(grd_selectStockEntry.Rows[0].Cells["sellingUnitPrice"].Value.ToString())) ? Convert.ToDouble(grd_selectStockEntry.Rows[0].Cells["sellingUnitPrice"].Value) : 0;
                StockIdQty = Convert.ToDouble(grd_selectStockEntry.Rows[0].Cells["remainQuantity"].Value);
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
