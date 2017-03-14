using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SystemDevelopment
{
    public partial class frm_Login : Form
    {
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsCommonMethods COMMON;
        
        public static string USERNAME;

        public frm_Login()
        {
            InitializeComponent();
            CONN = new CommonControls.Classes.dbConnection();
            COMMON = new CommonControls.Classes.ClsCommonMethods();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbl_userNameEmpty.Visible = false;
            lbl_passwdEmpty.Visible = false;
            lbl_invalidUser.Visible = false;

            if (txtUserName.Text == String.Empty)
            {
                lbl_userNameEmpty.Visible = true;
                lbl_userNameEmpty.Text = "User Name is empty";
                lbl_userNameEmpty.ForeColor = System.Drawing.Color.Red;
            }
            else if(txtPassword.Text == String.Empty)
            {
                lbl_passwdEmpty.Visible = true;
                lbl_passwdEmpty.Text = "Password is empty";
                lbl_passwdEmpty.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (isValidUser() == true)
                {
                    //MessageBox.Show("Valid User");
                    USERNAME = txtUserName.Text;
                    this.Hide();
                    Frm_Main MainForm = new Frm_Main();
                    MainForm.Show();
                }
                else
                {
                    lbl_invalidUser.Visible = true;
                    lbl_invalidUser.Text = "Invalid userName or Password";
                    lbl_invalidUser.ForeColor = System.Drawing.Color.Red;
                    txtPassword.Text = String.Empty;
                    txtUserName.Text = String.Empty;

                    //MessageBox.Show("Invalid userName or Password");
                }
            }
        }

        private bool isValidUser()
        {
            try 
            { 
                string userName = txtUserName.Text;
                string password = txtPassword.Text;
                string encriptPass = COMMON.EncodePassword(password);

                if (CONN.matchString(userName, encriptPass))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
    }
}
