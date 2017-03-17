namespace UserManage.CLL
{
    partial class FrmAddUserRole
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userRoleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_userRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_createUserRole = new System.Windows.Forms.Panel();
            this.pnl_createUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(200, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Create User Role";
            // 
            // txt_userRoleID
            // 
            this.txt_userRoleID.Enabled = false;
            this.txt_userRoleID.Location = new System.Drawing.Point(138, 71);
            this.txt_userRoleID.Name = "txt_userRoleID";
            this.txt_userRoleID.Size = new System.Drawing.Size(250, 19);
            this.txt_userRoleID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "User Role ID :";
            // 
            // txt_userRole
            // 
            this.txt_userRole.Location = new System.Drawing.Point(138, 116);
            this.txt_userRole.Name = "txt_userRole";
            this.txt_userRole.Size = new System.Drawing.Size(250, 19);
            this.txt_userRole.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Role :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(214, 348);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(313, 348);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_createUserRole
            // 
            this.pnl_createUserRole.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_createUserRole.Controls.Add(this.label4);
            this.pnl_createUserRole.Controls.Add(this.btn_cancel);
            this.pnl_createUserRole.Controls.Add(this.label5);
            this.pnl_createUserRole.Controls.Add(this.btn_add);
            this.pnl_createUserRole.Controls.Add(this.txt_userRoleID);
            this.pnl_createUserRole.Controls.Add(this.txt_userRole);
            this.pnl_createUserRole.Controls.Add(this.label1);
            this.pnl_createUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_createUserRole.Location = new System.Drawing.Point(0, 0);
            this.pnl_createUserRole.Name = "pnl_createUserRole";
            this.pnl_createUserRole.Size = new System.Drawing.Size(561, 467);
            this.pnl_createUserRole.TabIndex = 16;
            // 
            // FrmAddUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(561, 467);
            this.Controls.Add(this.pnl_createUserRole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUserRole";
            this.Text = "FrmAddUserRole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_createUserRoleClose);
            this.Load += new System.EventHandler(this.frm_createUserRoleLoad);
            this.pnl_createUserRole.ResumeLayout(false);
            this.pnl_createUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_userRoleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_userRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_createUserRole;
    }
}