using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManage.CLL
{
    public partial class FrmEditUserRole : Form
    {
        private BLL.ClsUserManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
    
        private static string USERNAME;

        public FrmEditUserRole()
        {
            InitializeComponent();
        }

        public FrmEditUserRole(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            MANAGEDB = new BLL.ClsUserManageDbChanges();
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
                col.DataPropertyName = "userRoleId";
                col.Name = "userRoleId";
                col.HeaderText = "userRoleId";
                grd_editRole.Columns.Add(col);
                grd_editRole.DataSource = MANAGEDB.getUserRoleDetails();
            }
            catch (Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void FrmEditUserRole_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_editRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int roleId = 0;
            BLL.clsUserRoleData roledata = new BLL.clsUserRoleData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        roleId = Convert.ToInt16(senderGrid.SelectedCells[e.ColumnIndex - 1].Value);
                        roledata = MANAGEDB.getSingleRoleData(roleId);

                        FrmAddUserRole addRole = new FrmAddUserRole(roledata, USERNAME);
                        addRole.WindowState = FormWindowState.Normal;
                        addRole.ShowDialog();
                        grd_editRole.DataSource = MANAGEDB.getUserRoleDetails();                        
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
