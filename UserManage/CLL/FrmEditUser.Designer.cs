namespace UserManage.CLL
{
    partial class FrmEditUser
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
            this.pnl_editUser = new System.Windows.Forms.Panel();
            this.grd_editUser = new System.Windows.Forms.DataGridView();
            this.pnl_editUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_editUser
            // 
            this.pnl_editUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_editUser.Controls.Add(this.grd_editUser);
            this.pnl_editUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_editUser.Location = new System.Drawing.Point(0, 0);
            this.pnl_editUser.Name = "pnl_editUser";
            this.pnl_editUser.Size = new System.Drawing.Size(834, 511);
            this.pnl_editUser.TabIndex = 0;
            // 
            // grd_editUser
            // 
            this.grd_editUser.AllowUserToAddRows = false;
            this.grd_editUser.AllowUserToDeleteRows = false;
            this.grd_editUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editUser.Location = new System.Drawing.Point(0, 0);
            this.grd_editUser.Name = "grd_editUser";
            this.grd_editUser.ReadOnly = true;
            this.grd_editUser.RowTemplate.Height = 21;
            this.grd_editUser.Size = new System.Drawing.Size(834, 511);
            this.grd_editUser.TabIndex = 9;
            this.grd_editUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_userEditCellClick);
            // 
            // FrmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.pnl_editUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditUser";
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.frm_editUserLoad);
            this.pnl_editUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_editUser;
        private System.Windows.Forms.DataGridView grd_editUser;
    }
}