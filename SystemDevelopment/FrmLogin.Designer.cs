namespace SystemDevelopment
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_userNameEmpty = new System.Windows.Forms.Label();
            this.lbl_passwdEmpty = new System.Windows.Forms.Label();
            this.lbl_invalidUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(297, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(123, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(288, 19);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(288, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_passWdKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // lbl_userNameEmpty
            // 
            this.lbl_userNameEmpty.AutoSize = true;
            this.lbl_userNameEmpty.Location = new System.Drawing.Point(140, 48);
            this.lbl_userNameEmpty.Name = "lbl_userNameEmpty";
            this.lbl_userNameEmpty.Size = new System.Drawing.Size(35, 12);
            this.lbl_userNameEmpty.TabIndex = 5;
            this.lbl_userNameEmpty.Text = "label3";
            // 
            // lbl_passwdEmpty
            // 
            this.lbl_passwdEmpty.AutoSize = true;
            this.lbl_passwdEmpty.Location = new System.Drawing.Point(142, 92);
            this.lbl_passwdEmpty.Name = "lbl_passwdEmpty";
            this.lbl_passwdEmpty.Size = new System.Drawing.Size(35, 12);
            this.lbl_passwdEmpty.TabIndex = 6;
            this.lbl_passwdEmpty.Text = "label3";
            // 
            // lbl_invalidUser
            // 
            this.lbl_invalidUser.AutoSize = true;
            this.lbl_invalidUser.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_invalidUser.Location = new System.Drawing.Point(15, 135);
            this.lbl_invalidUser.Name = "lbl_invalidUser";
            this.lbl_invalidUser.Size = new System.Drawing.Size(52, 16);
            this.lbl_invalidUser.TabIndex = 7;
            this.lbl_invalidUser.Text = "label3";
            this.lbl_invalidUser.Visible = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 172);
            this.Controls.Add(this.lbl_invalidUser);
            this.Controls.Add(this.lbl_passwdEmpty);
            this.Controls.Add(this.lbl_userNameEmpty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_FormCloseClick);
            this.Load += new System.EventHandler(this.frm_LoginFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_userNameEmpty;
        private System.Windows.Forms.Label lbl_passwdEmpty;
        private System.Windows.Forms.Label lbl_invalidUser;
    }
}

