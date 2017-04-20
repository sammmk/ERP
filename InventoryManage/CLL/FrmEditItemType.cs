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
    public partial class FrmEditItemType : Form
    {
        private BLL.ClsInventoryManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditItemType()
        {
            InitializeComponent();
        }

        public FrmEditItemType(string userName)
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
                col.DataPropertyName = "typeId";
                col.Name = "typeId";
                col.HeaderText = "Item Type Id";
                grd_editItemType.Columns.Add(col);
                grd_editItemType.DataSource = MANAGEDB.getItemTypeDetails();
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditItemType_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int itemTypeId = 0;
            BLL.ClsItemTypeData typeData = new BLL.ClsItemTypeData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        itemTypeId = Convert.ToInt16(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        typeData = MANAGEDB.getSingleItemTypeData(itemTypeId);

                        FrmAddItemType additemType = new FrmAddItemType(typeData, USERNAME);
                        additemType.WindowState = FormWindowState.Normal;
                        additemType.ShowDialog();
                        grd_editItemType.DataSource = MANAGEDB.getItemTypeDetails();
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
