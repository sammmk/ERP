namespace SystemDevelopment
{
    partial class FrmChangePassWd
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
            this.pnl_changPasswd = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_reNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_changPasswd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_changPasswd
            // 
            this.pnl_changPasswd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_changPasswd.Controls.Add(this.lbl_error);
            this.pnl_changPasswd.Controls.Add(this.label4);
            this.pnl_changPasswd.Controls.Add(this.btn_change);
            this.pnl_changPasswd.Controls.Add(this.btn_cancel);
            this.pnl_changPasswd.Controls.Add(this.txt_reNewPass);
            this.pnl_changPasswd.Controls.Add(this.label3);
            this.pnl_changPasswd.Controls.Add(this.txt_newPass);
            this.pnl_changPasswd.Controls.Add(this.label2);
            this.pnl_changPasswd.Controls.Add(this.txt_oldPass);
            this.pnl_changPasswd.Controls.Add(this.label1);
            this.pnl_changPasswd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_changPasswd.Location = new System.Drawing.Point(0, 0);
            this.pnl_changPasswd.Name = "pnl_changPasswd";
            this.pnl_changPasswd.Size = new System.Drawing.Size(457, 261);
            this.pnl_changPasswd.TabIndex = 0;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(182, 176);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(41, 12);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = "label5";
            this.lbl_error.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Change Password";
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_change.Location = new System.Drawing.Point(338, 209);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 30);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_cancel.Location = new System.Drawing.Point(250, 209);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_reNewPass
            // 
            this.txt_reNewPass.Location = new System.Drawing.Point(184, 139);
            this.txt_reNewPass.Name = "txt_reNewPass";
            this.txt_reNewPass.PasswordChar = '*';
            this.txt_reNewPass.Size = new System.Drawing.Size(229, 19);
            this.txt_reNewPass.TabIndex = 5;
            this.txt_reNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_reNewPassKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re Enter New Password :";
            // 
            // txt_newPass
            // 
            this.txt_newPass.Location = new System.Drawing.Point(184, 96);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '*';
            this.txt_newPass.Size = new System.Drawing.Size(229, 19);
            this.txt_newPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password :";
            // 
            // txt_oldPass
            // 
            this.txt_oldPass.Location = new System.Drawing.Point(184, 55);
            this.txt_oldPass.Name = "txt_oldPass";
            this.txt_oldPass.PasswordChar = '*';
            this.txt_oldPass.Size = new System.Drawing.Size(229, 19);
            this.txt_oldPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password :";
            // 
            // FrmChangePassWd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.pnl_changPasswd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassWd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_changePassWdClose);
            this.pnl_changPasswd.ResumeLayout(false);
            this.pnl_changPasswd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_changPasswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_reNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error;
    }
}