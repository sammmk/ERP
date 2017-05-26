using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaData.CLL
{
    public partial class FrmEditItem : Form
    {
        private BLL.ClsMetaDataDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditItem()
        {
            InitializeComponent();
        }

        public FrmEditItem(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsMetaDataDbChanges();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            USERNAME = userName;

            InitializeComponent();

            fillData();
        }

        private void fillData()
        {
            try
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.DataPropertyName = "itemId";
                col.Name = "itemId";
                col.HeaderText = "Item Id";
                grd_editItem.Columns.Add(col);
                grd_editItem.DataSource = MANAGEDB.getItemDetails();
                grd_editItem.Columns["deleteFlg"].Visible = false;

                cmb_search.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditItem_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int itemId = 0;
            BLL.ClsItemData itemData = new BLL.ClsItemData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        itemId = Convert.ToInt32(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        itemData = MANAGEDB.getSingleItemData(itemId);

                        FrmAddItem frmItem = new FrmAddItem(itemData, USERNAME);
                        frmItem.WindowState = FormWindowState.Normal;
                        frmItem.ShowDialog();
                        grd_editItem.DataSource = MANAGEDB.getItemDetails();
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

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int type = cmb_search.SelectedIndex;

            try
            {
                if (type == 1)
                {
                    dt = MANAGEDB.getItemWhileSearching(type, txt_search.Text);
                    grd_editItem.DataSource = dt;
                }
                else if (type > 1)
                {
                    txt_search.Focus();
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int type = cmb_search.SelectedIndex;

            try
            {
                if (type > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txt_search.Text))
                    {
                        dt = MANAGEDB.getItemWhileSearching(type, txt_search.Text);
                        grd_editItem.DataSource = dt;
                    }
                }
                else
                {
                    COM_MESSAGE.validationMessage("Please Select Type to Search ");
                }
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
