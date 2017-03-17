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
        private CommonControls.Classes.ClsValidation VALIDATION;
        private BLL.ClsUserManageData CREATEUSER;
        private BLL.ClsUserManageDbChanges MANAGEDB;

        private static bool IS_SUCCESS_MESSAGE = false;
        
        public FrmCreateUser()
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            CREATEUSER = new BLL.ClsUserManageData();
            MANAGEDB = new BLL.ClsUserManageDbChanges();

            InitializeComponent();

            txt_userID.Text = MANAGEDB.getMaxUserID().ToString();
            //fill data of user role from db
            dropDown_userRole.DataSource = MANAGEDB.getUserRoleList();
            dropDown_userRole.DisplayMember = "userRoleName";
            dropDown_userRole.ValueMember = "userRoleId";
            dropDown_userRole.BindingContext = this.BindingContext;
            dropDown_userRole.SelectedIndex = -1;

            btn_create.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;

            this.ActiveControl = txt_userName;
        }

        public FrmCreateUser(BLL.ClsUserManageData singleUserDetails)
        {
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            CREATEUSER = new BLL.ClsUserManageData();
            MANAGEDB = new BLL.ClsUserManageDbChanges();

            InitializeComponent();

            txt_userID.Text = singleUserDetails._userId.ToString();
            txt_userName.Text = singleUserDetails._userName;
            txt_firstName.Text = singleUserDetails._firstName;
            txt_lastName.Text = singleUserDetails._lastName;
            txt_dob.Text = singleUserDetails._dob.ToString("yyyy/MM/dd");
            txt_email.Text = singleUserDetails._email;
            txt_address.Text = singleUserDetails._address;
            txt_nic.Text = singleUserDetails._idNumber;
            txt_phoneNumber.Text = singleUserDetails._phoneNo.ToString();
            txt_userName.Enabled = false;

            dropDown_userRole.DataSource = MANAGEDB.getUserRoleList();
            dropDown_userRole.DisplayMember = "userRoleName";
            dropDown_userRole.ValueMember = "userRoleId";
            dropDown_userRole.BindingContext = this.BindingContext;
            dropDown_userRole.SelectedIndex = singleUserDetails._roleId - 1;

            btn_create.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            this.ActiveControl = txt_userName;
        }

        private void frm_CreateUserLoad(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CreateUserClose(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = DialogResult.Yes;

                if(!IS_SUCCESS_MESSAGE)
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
            string userRole = (dropDown_userRole.SelectedIndex != -1) ? dropDown_userRole.SelectedItem.ToString() : string.Empty;
            string phoneNo = txt_phoneNumber.Text;

            var dataList = new List<Tuple<string, string>>();

            dataList.Add(new Tuple<string, string>("userName", userName));
            dataList.Add(new Tuple<string, string>("firstName", firstName));
            dataList.Add(new Tuple<string, string>("lastName", lastName));
            dataList.Add(new Tuple<string, string>("idNumber", idNumber));
            dataList.Add(new Tuple<string, string>("email", email));
            dataList.Add(new Tuple<string, string>("userRole", userRole));
            dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));

            isError = checkInsertedUserData(dataList);

            try
            {
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
                    CREATEUSER._phoneNo = phoneNo;

                    //insert to tbl_userDetail and tbl_login
                    if (MANAGEDB.InsertData_userDetail(CREATEUSER))
                    {
                        COM_MESSAGE.successfullMessage("Successfully created the user ");
                        clearAllText(this);
                        dropDown_userRole.SelectedIndex = -1;
                        txt_userID.Text = MANAGEDB.getMaxUserID().ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void btn_updateClick(object sender, EventArgs e)
        {
            try
            {
                bool isError = false;
                string userName = txt_userName.Text;
                string firstName = txt_firstName.Text;
                string lastName = txt_lastName.Text;
                string idNumber = txt_nic.Text;
                string email = txt_email.Text;
                string userRole = (dropDown_userRole.SelectedIndex != -1) ? dropDown_userRole.SelectedItem.ToString() : string.Empty;
                string phoneNo = txt_phoneNumber.Text;

                var dataList = new List<Tuple<string, string>>();

                dataList.Add(new Tuple<string, string>("userName", userName));
                dataList.Add(new Tuple<string, string>("firstName", firstName));
                dataList.Add(new Tuple<string, string>("lastName", lastName));
                dataList.Add(new Tuple<string, string>("idNumber", idNumber));
                dataList.Add(new Tuple<string, string>("email", email));
                dataList.Add(new Tuple<string, string>("userRole", userRole));
                dataList.Add(new Tuple<string, string>("phoneNo", phoneNo));

                isError = checkInsertedUserData(dataList);

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
                    CREATEUSER._phoneNo = phoneNo;

                    //insert to tbl_userDetail and tbl_login
                    if (MANAGEDB.updateData_userDetail(CREATEUSER))
                    {
                        IS_SUCCESS_MESSAGE = true;
                        this.Close();
                        COM_MESSAGE.successfullMessage("Successfully Updated the user ");                        
                    }
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private bool checkInsertedUserData(List<Tuple<string,string>> userData)
        {
            bool isError = false;

            try
            {
                for (int i = 0; i < userData.Count; i++)
                {
                    switch(userData[i].Item1)
                    {
                        //validate User Name
                        case "userName":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("User Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("User Name should contains only Letters and Numbers !!!");
                                    isError = true;
                                }
                            }
                            break;

                        //validate First Name
                        case "firstName":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("First Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("First Name should contains only Letters !!!");
                                    isError = true;
                                }
                            }
                            break;

                        //validate Last Name
                        case "lastName":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("Last Name Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Last Name should contains only Letters !!!");
                                    isError = true;
                                }
                            }
                            break;

                        //validate NIC
                        case "idNumber":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("NIC Cannot be Empty !!!");
                                isError = true;
                            }
                            else
                            {
                                if (!VALIDATION.isLetterAndNumberOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("NIC should contains only Letters and Numbers !!!");
                                    isError = true;
                                }
                            }
                            break;

                        //validate email - it can be empty
                        case "email":
                            if (!VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                if (!VALIDATION.isEmail(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("email is not in correct format !!!");
                                    isError = true;
                                }
                            }
                            break;

                        //validate user Role
                        case "userRole":
                            if (VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                COM_MESSAGE.validationMessage("User Role Cannot be Empty !!!");
                                isError = true;
                            }
                            break;

                        //validate Phone number
                        case "phoneNo":
                            if (!VALIDATION.isEmptyTextBox(userData[i].Item2))
                            {
                                if (!VALIDATION.isNumberOnly(userData[i].Item2))
                                {
                                    COM_MESSAGE.validationMessage("Phone Number should contains only Numbers !!!");
                                    isError = true;
                                }
                            }
                            break;
                        default:
                            isError = true;
                            break;
                    }
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isError;
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = COM_MESSAGE.warningMessage("You are going to DELETE the user....\n\r Are you Sure???", "Delete the User");

            if(result == DialogResult.Yes)
            {
                if(MANAGEDB.deleteUser(Convert.ToInt16(txt_userID.Text)))
                {
                    IS_SUCCESS_MESSAGE = true;
                    this.Close();
                    COM_MESSAGE.successfullMessage("Successfully deleted the User");
                }
            }
        }
    }
}
