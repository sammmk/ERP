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
        private BLL.ClsUserManageDbChanges MANAGEDB;

        public FrmAddUserRole()
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            MANAGEDB = new BLL.ClsUserManageDbChanges();

            InitializeComponent();
        }


        private void frm_createUserRoleLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //get max user role Id
            txt_userRoleID.Text = MANAGEDB.getMaxUserRoleId().ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_createUserRoleClose(object sender, FormClosingEventArgs e)
        {
            DialogResult result = COM_MESSAGE.informationMessage("Do you realy want to CANCEL!!! you will lost all unsaved data", "Confirmation");

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isError = false;
            int userRoleId = Convert.ToInt16(txt_userRoleID.Text);
            string userRole = txt_userRole.Text;

            try
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

                if(!isError)
                {
                    //insert data to tbl_userrole
                    if(MANAGEDB.insertData_userRole(userRoleId, userRole))
                    {
                        COM_MESSAGE.informationMessage("Successfully created the user Role ", "DONE");
                        clearAllText(this);
                        txt_userRoleID.Text = MANAGEDB.getMaxUserRoleId().ToString();
                    }
                }
            }
            catch(Exception ex)
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
    }
}
