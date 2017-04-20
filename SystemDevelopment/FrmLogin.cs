using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelopment
{
    public partial class frm_Login : Form
    {
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsCommonMethods COMMON;
        private CommonControls.Classes.ClsMessages COMM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        
        public static string USERNAME;

        public frm_Login()
        {
            InitializeComponent();
            CONN = new CommonControls.Classes.dbConnection();
            COMMON = new CommonControls.Classes.ClsCommonMethods();
            COMM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();

            this.ActiveControl = txtUserName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbl_userNameEmpty.Visible = false;
            lbl_passwdEmpty.Visible = false;
            lbl_invalidUser.Visible = false;
            pnl_userName.BackgroundImage = null;
            pnl_pass.BackgroundImage = null;
            bool isError = false;

            try
            {
                //validate userName
                if (VALIDATION.isEmptyTextBox(txtUserName.Text))
                {
                    lbl_userNameEmpty.Visible = true;
                    lbl_userNameEmpty.Text = "User Name is empty";
                    lbl_userNameEmpty.ForeColor = Color.Red;
                    pnl_userName.BackgroundImage = (Image)CommonControls.Properties.Resources.ng;
                    txtUserName.Focus();
                    isError = true;
                }
                else
                {
                    if (VALIDATION.isSpecialChars(txtUserName.Text))
                    {
                        lbl_userNameEmpty.Visible = true;
                        lbl_userNameEmpty.Text = "User Name Cannot contains special characters";
                        lbl_userNameEmpty.ForeColor = Color.Red;
                        pnl_userName.BackgroundImage = (Image)CommonControls.Properties.Resources.ng;
                        txtUserName.Focus();
                        isError = true;
                    }
                }

                if (VALIDATION.isEmptyTextBox(txtPassword.Text))
                {
                    lbl_passwdEmpty.Visible = true;
                    lbl_passwdEmpty.Text = "Password is empty";
                    lbl_passwdEmpty.ForeColor = Color.Red;
                    pnl_pass.BackgroundImage = (Image)CommonControls.Properties.Resources.ng;
                    txtPassword.Focus();
                    isError = true;
                }
                else
                {
                    if (VALIDATION.isSpecialChars(txtPassword.Text))
                    {
                        lbl_passwdEmpty.Visible = true;
                        lbl_passwdEmpty.Text = "Password cannot contains special characters";
                        lbl_passwdEmpty.ForeColor = Color.Red;
                        pnl_pass.BackgroundImage = (Image)CommonControls.Properties.Resources.ng;
                        txtPassword.Focus();
                        isError = true;
                    }
                }

                if(!isError)
                {
                    if (isValidUser())
                    {
                        USERNAME = txtUserName.Text;
                        this.Hide();
                        Frm_Main MainForm = new Frm_Main();
                        MainForm.Show();
                    }
                    else
                    {
                        lbl_invalidUser.Visible = true;
                        lbl_invalidUser.Text = "Invalid userName or Password";
                        lbl_invalidUser.ForeColor = Color.Red;
                        txtPassword.Text = String.Empty;
                        txtUserName.Text = String.Empty;
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                COMM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private bool isValidUser()
        {
            bool ret = false;

            try 
            { 
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string encriptPass = COMMON.EncodePassword(password);

                if (CONN.matchString(userName, encriptPass))
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }
            catch(Exception ex)
            {
                ret = false;
                throw ex;
            }

            return ret;
        }
        
        private void frm_FormCloseClick(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_LoginFormLoad(object sender, EventArgs e)
        {
            lbl_userNameEmpty.Visible = false;
            lbl_passwdEmpty.Visible = false;
            lbl_invalidUser.Visible = false;
            this.ActiveControl = txtUserName;
        }
        
        private void txt_passWdKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
