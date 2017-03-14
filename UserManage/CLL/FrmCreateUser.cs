using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManage
{
    public partial class FrmCreateUser : Form
    {
        //private formCreateUser = new FrmCreateUser();

        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private BLL.ClsUserManageData CREATEUSER;

        private BLL.ClsUserManageDbChanges MANAGEDB;

        private int COMID = 1000;

        public FrmCreateUser()
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            CONN = new CommonControls.Classes.dbConnection();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            CREATEUSER = new BLL.ClsUserManageData();
            MANAGEDB = new BLL.ClsUserManageDbChanges();

            InitializeComponent();
        }

        private void frm_CreateUserLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt_userID.Text = Convert.ToString(createUserId());

            //fill data of user role from db
            dropDown_userRole.DataSource = MANAGEDB.userRoleList();
            dropDown_userRole.DisplayMember = "userRoleList";
            dropDown_userRole.ValueMember = "userRoleId";
            dropDown_userRole.BindingContext = this.BindingContext;
            dropDown_userRole.SelectedIndex = -1;

            this.ActiveControl = txt_userName;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CreateUserClose(object sender, FormClosingEventArgs e)
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

        private int createUserId()
        {
            int ret = 0;

            //get the maximum userId
            try
            {
                MANAGEDB.maxUserID(out ret);

                if (ret <= 0)
                {
                    ret = COMID + 1;
                }
                else
                {
                    ret = ret + 1;
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }       
            
            return ret;
        }

        private void dobSelectedValue(object sender, EventArgs e)
        {
            DateTime result =  dateTimePicker_dob.Value.Date;   
            txt_dob.Text = result.ToString("yyyy/MM/dd");
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string userName = txt_userName.Text;
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string idNumber = txt_nic.Text;
            string email = txt_email.Text;
            string userRole = string.Empty;
            string phoneNo = txt_phoneNumber.Text;

            try
            {
                if (dropDown_userRole.SelectedIndex != -1)
                    userRole = dropDown_userRole.SelectedItem.ToString();

                //validate User Name
                if (VALIDATION.isEmptyTextBox(userName))
                {
                    COM_MESSAGE.validationMessage("User Name Cannot be Empty !!!");
                    isError = true;
                }
                else
                {
                    if (!VALIDATION.isLetterAndNumberOnly(userName))
                    {
                        COM_MESSAGE.validationMessage("User Name should contains only Letters and Numbers !!!");
                        isError = true;
                    }
                }

                //validate First Name
                if (VALIDATION.isEmptyTextBox(firstName))
                {
                    COM_MESSAGE.validationMessage("First Name Cannot be Empty !!!");
                    isError = true;
                }
                else
                {
                    if (!VALIDATION.isLetterOnly(firstName))
                    {
                        COM_MESSAGE.validationMessage("First Name should contains only Letters !!!");
                        isError = true;
                    }
                }

                //validate Last Name
                if (VALIDATION.isEmptyTextBox(lastName))
                {
                    COM_MESSAGE.validationMessage("Last Name Cannot be Empty !!!");
                    isError = true;
                }
                else
                {
                    if (!VALIDATION.isLetterOnly(lastName))
                    {
                        COM_MESSAGE.validationMessage("Last Name should contains only Letters !!!");
                        isError = true;
                    }
                }

                //validate NIC
                if (VALIDATION.isEmptyTextBox(idNumber))
                {
                    COM_MESSAGE.validationMessage("NIC Cannot be Empty !!!");
                    isError = true;
                }
                else
                {
                    if (!VALIDATION.isLetterAndNumberOnly(idNumber))
                    {
                        COM_MESSAGE.validationMessage("NIC should contains only Letters and Numbers !!!");
                        isError = true;
                    }
                }

                //validate email - it can be empty
                if (!VALIDATION.isEmptyTextBox(email))
                {
                    if (!VALIDATION.isEmail(email))
                    {
                        COM_MESSAGE.validationMessage("email is not in correct format !!!");
                        isError = true;
                    }
                }

                //validate user Role
                if (VALIDATION.isEmptyTextBox(userRole))
                {
                    COM_MESSAGE.validationMessage("User Role Cannot be Empty !!!");
                    isError = true;
                }

                //validate Phone number
                if (!VALIDATION.isEmptyTextBox(phoneNo))
                {
                    if (!VALIDATION.isNumberOnly(phoneNo))
                    {
                        COM_MESSAGE.validationMessage("Phone Number should contains only Numbers !!!");
                        isError = true;
                    }
                }

                if (!isError)
                {
                    //insert data to db
                    CREATEUSER._userId = Convert.ToInt16(txt_userID.Text);
                    CREATEUSER._userName = userName;
                    CREATEUSER._firstName = firstName;
                    CREATEUSER._lastName = lastName;
                    CREATEUSER._dob = Convert.ToDateTime(txt_dob.Text);
                    CREATEUSER._idNumber = idNumber;
                    CREATEUSER._address = txt_address.Text;
                    CREATEUSER._email = email;
                    CREATEUSER._userRole = userRole;
                    CREATEUSER._roleId = Convert.ToInt16(dropDown_userRole.SelectedValue);

                    BLL.ClsUserManageDbChanges dbChange = new BLL.ClsUserManageDbChanges();

                    //insert to tbl_userDetail and tbl_login
                    if (MANAGEDB.InsertData_userDetail(CREATEUSER))
                    {
                        COM_MESSAGE.informationMessage("Successfully created the user ", "DONE");
                        clearAllText(this);
                        dropDown_userRole.SelectedIndex = -1;
                        txt_userID.Text = Convert.ToString(createUserId());
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }


        /// <summary>
        /// clear all text boxes
        /// </summary>
        /// <param name="con"></param>
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
