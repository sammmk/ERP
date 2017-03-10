﻿namespace SystemDevelopment
{
    partial class Frm_Main
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.lbl_loggedUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_userManage = new System.Windows.Forms.Panel();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.btn_userManage = new System.Windows.Forms.Button();
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_userManage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Controls.Add(this.pnl_userManage);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(893, 507);
            this.pnl_menu.TabIndex = 1;
            // 
            // lbl_loggedUser
            // 
            this.lbl_loggedUser.AutoSize = true;
            this.lbl_loggedUser.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_loggedUser.Location = new System.Drawing.Point(671, 15);
            this.lbl_loggedUser.Name = "lbl_loggedUser";
            this.lbl_loggedUser.Size = new System.Drawing.Size(71, 12);
            this.lbl_loggedUser.TabIndex = 4;
            this.lbl_loggedUser.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logged In As : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Location = new System.Drawing.Point(815, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "LogOut";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_userManage
            // 
            this.pnl_userManage.Controls.Add(this.btn_editUser);
            this.pnl_userManage.Controls.Add(this.btn_createUser);
            this.pnl_userManage.Controls.Add(this.btn_userManage);
            this.pnl_userManage.Location = new System.Drawing.Point(3, 45);
            this.pnl_userManage.Name = "pnl_userManage";
            this.pnl_userManage.Size = new System.Drawing.Size(199, 74);
            this.pnl_userManage.TabIndex = 0;
            // 
            // btn_editUser
            // 
            this.btn_editUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editUser.Location = new System.Drawing.Point(0, 48);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(199, 23);
            this.btn_editUser.TabIndex = 2;
            this.btn_editUser.Text = "      Edit User";
            this.btn_editUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editUser.UseVisualStyleBackColor = true;
            // 
            // btn_createUser
            // 
            this.btn_createUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createUser.Location = new System.Drawing.Point(0, 25);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(199, 23);
            this.btn_createUser.TabIndex = 1;
            this.btn_createUser.Text = "      Create User";
            this.btn_createUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createUser.UseVisualStyleBackColor = true;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_userManage
            // 
            this.btn_userManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_userManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_userManage.Location = new System.Drawing.Point(0, 0);
            this.btn_userManage.Name = "btn_userManage";
            this.btn_userManage.Size = new System.Drawing.Size(199, 25);
            this.btn_userManage.TabIndex = 0;
            this.btn_userManage.Text = "   User Manage";
            this.btn_userManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userManage.UseVisualStyleBackColor = true;
            this.btn_userManage.Click += new System.EventHandler(this.btn_userManage_Click);
            // 
            // pnl_forms
            // 
            this.pnl_forms.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_forms.Location = new System.Drawing.Point(213, 45);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(673, 459);
            this.pnl_forms.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lbl_loggedUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 35);
            this.panel1.TabIndex = 5;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(893, 507);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnl_menu);
            this.Name = "Frm_Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_userManage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_userManage;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.Button btn_createUser;
        private System.Windows.Forms.Button btn_userManage;
        private System.Windows.Forms.Panel pnl_forms;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loggedUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}