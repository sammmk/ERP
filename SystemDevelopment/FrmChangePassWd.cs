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
    public partial class FrmChangePassWd : Form
    {
        private CommonControls.Classes.ClsMessages COM_MESSAGE;
        private CommonControls.Classes.ClsValidation VALIDATION;
        private CommonControls.Classes.ClsCommonMethods COMM_METHOD;
        private CommonControls.Classes.dbConnection CONN;

        public static bool IS_SUCCESS_MESSAGE = false;
        private static string USERNAME;

        public FrmChangePassWd(string UserName)
        {
            InitializeComponent();
            COM_MESSAGE = new CommonControls.Classes.ClsMessages();
            VALIDATION = new CommonControls.Classes.ClsValidation();
            COMM_METHOD = new CommonControls.Classes.ClsCommonMethods();
            CONN = new CommonControls.Classes.dbConnection();
            USERNAME = UserName;

            this.ActiveControl = txt_oldPass;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_changePassWdClose(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = DialogResult.Yes;

                if (!IS_SUCCESS_MESSAGE)
                    result = COM_MESSAGE.informationMessage("Do you realy want to CLOSE!!! you will lost all unsaved data", "Confirmation");

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

        private void btn_change_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string oldPass = txt_oldPass.Text;
            string newPass = txt_newPass.Text;
            string reNewPass = txt_reNewPass.Text;
            string en_oldPass = string.Empty;
            string en_newPass = string.Empty;
            string en_reNewPass = string.Empty;

            lbl_error.Visible = false;

            try
            {
                //check the inserted values are empty
                if (VALIDATION.isEmptyTextBox(oldPass))
                {
                    isError = true;
                    COM_MESSAGE.validationMessage("Old password cannot be Empty !!!");
                }

                if (VALIDATION.isEmptyTextBox(newPass))
                {
                    isError = true;
                    COM_MESSAGE.validationMessage("New password cannot be Empty !!!");
                }

                if (VALIDATION.isEmptyTextBox(reNewPass))
                {
                    isError = true;
                    COM_MESSAGE.validationMessage("Re-Enter New password cannot be Empty !!!");
                }

                if (!isError)
                {
                    if (newPass.Equals(reNewPass, StringComparison.Ordinal))
                    {
                        en_oldPass = COMM_METHOD.EncodePassword(oldPass);
                        en_newPass = COMM_METHOD.EncodePassword(newPass);
                        en_reNewPass = COMM_METHOD.EncodePassword(reNewPass);

                        if(CONN.matchString(USERNAME, en_oldPass))
                        {
                            //change the password in tbl_login
                            if (CONN.changePassword(USERNAME, en_newPass))
                            {
                                COMM_METHOD.clearAllText(this);
                                COM_MESSAGE.successfullMessage("Successfully changed the password !!!");
                                IS_SUCCESS_MESSAGE = true;
                                this.Close();

                                
                            }
                        }
                        else
                        {
                            lbl_error.Visible = true;
                            lbl_error.Text = "Current Password is incorrect !!!";
                            COMM_METHOD.clearAllText(this);
                            txt_oldPass.Focus();
                        }
                    }
                    else
                    {
                        lbl_error.Visible = true;
                        lbl_error.Text = "New passwords doen't match each other";
                        txt_newPass.Text = string.Empty;
                        txt_reNewPass.Text = string.Empty;
                        txt_newPass.Focus();
                    }                
                }
            }
            catch(Exception ex)
            {
                COM_MESSAGE.exceptionMessage(ex.Message);
            }
        }

        private void txt_reNewPassKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_change.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
