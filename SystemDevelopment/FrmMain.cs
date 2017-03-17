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
    public partial class Frm_Main : Form
    {
        private FormWindowState prevState;

        public Frm_Main()
        {
            InitializeComponent();
            prevState = this.WindowState;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //load main form in maximize state
            this.WindowState = FormWindowState.Maximized;

            pnl_userManage.Height = 25;
            btn_userManage.Image = Properties.Resources.down;
            lbl_loggedUser.Text = frm_Login.USERNAME;
        }

        /// <summary>
        /// expand the Use_Manage menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_userManage_Click(object sender, EventArgs e)
        {
            if (pnl_userManage.Height == 25)
            {
                pnl_userManage.Height = (25 * 4) + 2;
                btn_userManage.Image = Properties.Resources.up;
            }
            else
            {
                pnl_userManage.Height = 25;
                btn_userManage.Image = Properties.Resources.down;
            }
        }        

        /// <summary>
        /// Open the form create_user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createUser_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;

            UserManage.FrmCreateUser createUser = new UserManage.FrmCreateUser();
            
            isFormOpen = windowOpenCheck(createUser.Name);

            if (isFormOpen)
            {
                createUser.BringToFront();
            }
            else
            {
                createUser.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(createUser);
                createUser.WindowState = FormWindowState.Maximized;
                createUser.Show();
            }
        }

        private void btn_userRole_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;

            UserManage.CLL.FrmAddUserRole addUserRole = new UserManage.CLL.FrmAddUserRole();
            
            isFormOpen = windowOpenCheck(addUserRole.Name);

            if (isFormOpen)
            {
                addUserRole.BringToFront();
            }
            else
            {
                addUserRole.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(addUserRole);

                addUserRole.Show();
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            UserManage.CLL.FrmEditUser editUser = new UserManage.CLL.FrmEditUser();

            isFormOpen = windowOpenCheck(editUser.Name);

            if (isFormOpen)
            {
                editUser.BringToFront();
            }
            else
            {
                editUser.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(editUser);

                editUser.Show();
            }
        }

        private bool windowOpenCheck(string frmName)
        {
            bool ret = false;
            FormCollection FC = Application.OpenForms;

            try
            {
                foreach(Form frm in FC)
                {
                    if (frm.Name.Equals(frmName))
                    {
                        ret = true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        /// <summary>
        /// expandable menu
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            if (prevState != this.WindowState)
            {
                prevState = this.WindowState;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    //this.FormBorderStyle = FormBorderStyle.None;
                    //pnl_forms.Size = this.ClientSize;
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    //this.FormBorderStyle = FormBorderStyle.Sizable;
                    //pnl_forms.Size = pnl_formsSize;
                }
            }
            base.OnResize(e);
        }

        /// <summary>
        /// Logout button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login LoginForm = new frm_Login();
            LoginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
