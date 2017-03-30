namespace UserManage.CLL
{
    partial class FrmEditUserRole
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
            this.pnl_editRole = new System.Windows.Forms.Panel();
            this.grd_editRole = new System.Windows.Forms.DataGridView();
            this.pnl_editRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editRole)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_editRole
            // 
            this.pnl_editRole.Controls.Add(this.grd_editRole);
            this.pnl_editRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_editRole.Location = new System.Drawing.Point(0, 0);
            this.pnl_editRole.Name = "pnl_editRole";
            this.pnl_editRole.Size = new System.Drawing.Size(778, 477);
            this.pnl_editRole.TabIndex = 0;
            // 
            // grd_editRole
            // 
            this.grd_editRole.AllowUserToAddRows = false;
            this.grd_editRole.AllowUserToDeleteRows = false;
            this.grd_editRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editRole.Location = new System.Drawing.Point(0, 0);
            this.grd_editRole.Name = "grd_editRole";
            this.grd_editRole.ReadOnly = true;
            this.grd_editRole.RowTemplate.Height = 21;
            this.grd_editRole.Size = new System.Drawing.Size(778, 477);
            this.grd_editRole.TabIndex = 0;
            this.grd_editRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editRole_CellContentClick);
            // 
            // FrmEditUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 477);
            this.Controls.Add(this.pnl_editRole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditUserRole";
            this.Text = "Edit User Role";
            this.Load += new System.EventHandler(this.FrmEditUserRole_Load);
            this.pnl_editRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_editRole;
        private System.Windows.Forms.DataGridView grd_editRole;
    }
}