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
    public partial class FrmEditItem : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
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
            MANAGEDB = new BLL.ClsInventoryManageDbChanges();
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

                        FrmAddItem frmUser = new FrmAddItem(itemData, USERNAME);
                        frmUser.WindowState = FormWindowState.Normal;
                        frmUser.ShowDialog();
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

    }
}
