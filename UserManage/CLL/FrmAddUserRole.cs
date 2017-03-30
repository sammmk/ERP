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
    public partial class FrmAddUserRole : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHODS;
        private BLL.ClsUserManageDbChanges MANAGEDB;

        private static string USERNAME;
        private static bool IS_UPDATING = false;
        private static bool IS_SUCCESS_MESSAGE = false;

        public FrmAddUserRole()
        {
            InitializeComponent();
        }

        public FrmAddUserRole(string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            MANAGEDB = new BLL.ClsUserManageDbChanges();

            InitializeComponent();

            USERNAME = userName;
            btn_update.Visible = false;
            btn_add.Visible = true;

        }

        public FrmAddUserRole(BLL.clsUserRoleData roleData, string userName)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHODS = new CommonControls.Classes.ClsCommonMethods();
            MANAGEDB = new BLL.ClsUserManageDbChanges();
            USERNAME = userName;

            InitializeComponent();

            txt_userRoleID.Text = roleData._roleId.ToString();
            txt_userRole.Text = roleData._roleName;

            IS_UPDATING = true;
            btn_update.Visible = true;
            btn_add.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txt_userRole;

        }

        private void frm_createUserRoleLoad(object sender, EventArgs e)
        {
            if (!IS_UPDATING)
            {
                //get max user role Id
                txt_userRoleID.Text = MANAGEDB.getMaxUserRoleId().ToString();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_createUserRoleClose(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = DialogResult.Yes;

                if (!IS_SUCCESS_MESSAGE)
                    result = COM_MESSAGE.informationMessage("Do you realy want to CANCEL!!! you will lost all unsaved data", "Confirmation");

                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isError = false;
            int userRoleId = Convert.ToInt16(txt_userRoleID.Text);
            string userRole = txt_userRole.Text;

            try
            {
                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    //validate User Role
                    if (VALIDATION.isEmptyTextBox(userRole))
                    {
                        COM_MESSAGE.validationMessage("User Role Cannot be Empty !!!");
                        isError = true;
                    }
                    else
                    {
                        if (!VALIDATION.isLetterAndNumberOnly(userRole))
                        {
                            COM_MESSAGE.validationMessage("User Role should contains only Letters and Numbers !!!");
                            isError = true;
                        }
                    }

                    if (!isError)
                    {
                        //insert data to tbl_userrole
                        if (MANAGEDB.insertData_userRole(userRoleId, userRole))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            COM_MESSAGE.successfullMessage("Successfully created the user Role ");
                            clearAllText(this);
                            txt_userRoleID.Text = MANAGEDB.getMaxUserRoleId().ToString();
                        }
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

        private void clearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllText(c);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                bool isError = false;
                int userRoleId = Convert.ToInt16(txt_userRoleID.Text);
                string userRole = txt_userRole.Text;

                //check for do action
                if (COMM_METHODS.checkActPermission(this.Name, USERNAME))
                {
                    //validate User Role
                    if (VALIDATION.isEmptyTextBox(userRole))
                    {
                        COM_MESSAGE.validationMessage("User Role Cannot be Empty !!!");
                        isError = true;
                    }
                    else
                    {
                        if (!VALIDATION.isLetterAndNumberOnly(userRole))
                        {
                            COM_MESSAGE.validationMessage("User Role should contains only Letters and Numbers !!!");
                            isError = true;
                        }
                    }

                    if (!isError)
                    {
                        //update data to tbl_userrole
                        if (MANAGEDB.updateData_userRole(userRoleId, userRole))
                        {
                            IS_SUCCESS_MESSAGE = true;
                            COM_MESSAGE.successfullMessage("Successfully Updated the user Role ");
                            this.Close();
                        }
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
