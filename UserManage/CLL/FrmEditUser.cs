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
    public partial class FrmEditUser : Form
    {
        private BLL.ClsUserManageDbChanges MANAGEDB;
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;

        private static string USERNAME;

        public FrmEditUser()
        {
            InitializeComponent();
        }

        public FrmEditUser(string userName)
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
                col.DataPropertyName = "userId";
                col.Name = "userId";
                col.HeaderText = "userId";
                grd_editUser.Columns.Add(col);
                grd_editUser.DataSource = MANAGEDB.getUserDetails();
                grd_editUser.Columns["deleteFlg"].Visible = false;
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void frm_editUserLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void grd_userEditCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int userId = 0;
            BLL.ClsUserManageData userData = new BLL.ClsUserManageData();

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        userId = Convert.ToInt16(senderGrid.SelectedCells[e.ColumnIndex].Value);
                        userData = MANAGEDB.getSingleUserData(userId);

                        FrmCreateUser frmUser = new FrmCreateUser(userData, USERNAME);
                        frmUser.WindowState = FormWindowState.Normal;
                        frmUser.ShowDialog();
                        grd_editUser.DataSource = MANAGEDB.getUserDetails();
                    }
                }
                else
                {
                    COM_MESSAGE.permissionMessage("Sorry You dont have permission to do action !!!");
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }
    }
}
