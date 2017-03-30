namespace UserManage
{
    partial class FrmCreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_createUser = new System.Windows.Forms.Panel();
            this.pnl_validate = new System.Windows.Forms.Panel();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.dropDown_userRole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_createUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(120, 111);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(250, 19);
            this.txt_firstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(500, 111);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(250, 19);
            this.txt_lastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth :";
            // 
            // txt_dob
            // 
            this.txt_dob.Enabled = false;
            this.txt_dob.Location = new System.Drawing.Point(120, 147);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(139, 19);
            this.txt_dob.TabIndex = 5;
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Location = new System.Drawing.Point(278, 147);
            this.dateTimePicker_dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(92, 19);
            this.dateTimePicker_dob.TabIndex = 6;
            this.dateTimePicker_dob.ValueChanged += new System.EventHandler(this.dobSelectedValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(373, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create User Profile";
            // 
            // pnl_createUser
            // 
            this.pnl_createUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_createUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_createUser.Controls.Add(this.pnl_validate);
            this.pnl_createUser.Controls.Add(this.lbl_userName);
            this.pnl_createUser.Controls.Add(this.btn_delete);
            this.pnl_createUser.Controls.Add(this.btn_update);
            this.pnl_createUser.Controls.Add(this.label11);
            this.pnl_createUser.Controls.Add(this.txt_phoneNumber);
            this.pnl_createUser.Controls.Add(this.dropDown_userRole);
            this.pnl_createUser.Controls.Add(this.label4);
            this.pnl_createUser.Controls.Add(this.label10);
            this.pnl_createUser.Controls.Add(this.btn_cancel);
            this.pnl_createUser.Controls.Add(this.btn_create);
            this.pnl_createUser.Controls.Add(this.label9);
            this.pnl_createUser.Controls.Add(this.txt_email);
            this.pnl_createUser.Controls.Add(this.label8);
            this.pnl_createUser.Controls.Add(this.txt_address);
            this.pnl_createUser.Controls.Add(this.label7);
            this.pnl_createUser.Controls.Add(this.txt_nic);
            this.pnl_createUser.Controls.Add(this.label6);
            this.pnl_createUser.Controls.Add(this.txt_userName);
            this.pnl_createUser.Controls.Add(this.txt_userID);
            this.pnl_createUser.Controls.Add(this.label5);
            this.pnl_createUser.Controls.Add(this.txt_firstName);
            this.pnl_createUser.Controls.Add(this.label1);
            this.pnl_createUser.Controls.Add(this.dateTimePicker_dob);
            this.pnl_createUser.Controls.Add(this.label2);
            this.pnl_createUser.Controls.Add(this.txt_dob);
            this.pnl_createUser.Controls.Add(this.txt_lastName);
            this.pnl_createUser.Controls.Add(this.label3);
            this.pnl_createUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_createUser.Location = new System.Drawing.Point(0, 0);
            this.pnl_createUser.Name = "pnl_createUser";
            this.pnl_createUser.Size = new System.Drawing.Size(938, 496);
            this.pnl_createUser.TabIndex = 8;
            // 
            // pnl_validate
            // 
            this.pnl_validate.Location = new System.Drawing.Point(762, 60);
            this.pnl_validate.Name = "pnl_validate";
            this.pnl_validate.Size = new System.Drawing.Size(36, 36);
            this.pnl_validate.TabIndex = 25;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_userName.ForeColor = System.Drawing.Color.Red;
            this.lbl_userName.Location = new System.Drawing.Point(804, 70);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(48, 12);
            this.lbl_userName.TabIndex = 24;
            this.lbl_userName.Text = "label12";
            this.lbl_userName.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete.Location = new System.Drawing.Point(815, 459);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(688, 459);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_updateClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "Phone No :";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(120, 395);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(250, 19);
            this.txt_phoneNumber.TabIndex = 11;
            // 
            // dropDown_userRole
            // 
            this.dropDown_userRole.FormattingEnabled = true;
            this.dropDown_userRole.Location = new System.Drawing.Point(120, 354);
            this.dropDown_userRole.Name = "dropDown_userRole";
            this.dropDown_userRole.Size = new System.Drawing.Size(250, 20);
            this.dropDown_userRole.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Role of the User :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(576, 459);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(675, 459);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 13;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "E-Mail :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 311);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 19);
            this.txt_email.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address :";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(120, 228);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(250, 60);
            this.txt_address.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID Number :";
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(120, 188);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(250, 19);
            this.txt_nic.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "User Name :";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(500, 70);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(250, 19);
            this.txt_userName.TabIndex = 2;
            this.txt_userName.Leave += new System.EventHandler(this.txt_userName_Leave);
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Location = new System.Drawing.Point(120, 70);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(250, 19);
            this.txt_userID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "User ID :";
            // 
            // FrmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(938, 496);
            this.Controls.Add(this.pnl_createUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CreateUserClose);
            this.Load += new System.EventHandler(this.frm_CreateUserLoad);
            this.pnl_createUser.ResumeLayout(false);
            this.pnl_createUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_createUser;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dropDown_userRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Panel pnl_validate;
    }
}

