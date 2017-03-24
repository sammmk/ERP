namespace UserManage.CLL
{
    partial class FrmSetUserPermission
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
            this.pnl_data = new System.Windows.Forms.Panel();
            this.splitCon_userPermission = new System.Windows.Forms.SplitContainer();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_userPermission = new System.Windows.Forms.DataGridView();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCon_userPermission)).BeginInit();
            this.splitCon_userPermission.Panel1.SuspendLayout();
            this.splitCon_userPermission.Panel2.SuspendLayout();
            this.splitCon_userPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_userPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_data.Controls.Add(this.splitCon_userPermission);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(898, 499);
            this.pnl_data.TabIndex = 0;
            // 
            // splitCon_userPermission
            // 
            this.splitCon_userPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCon_userPermission.Location = new System.Drawing.Point(0, 0);
            this.splitCon_userPermission.Name = "splitCon_userPermission";
            this.splitCon_userPermission.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCon_userPermission.Panel1
            // 
            this.splitCon_userPermission.Panel1.Controls.Add(this.btn_save);
            this.splitCon_userPermission.Panel1.Controls.Add(this.txt_search);
            this.splitCon_userPermission.Panel1.Controls.Add(this.label1);
            // 
            // splitCon_userPermission.Panel2
            // 
            this.splitCon_userPermission.Panel2.Controls.Add(this.grd_userPermission);
            this.splitCon_userPermission.Size = new System.Drawing.Size(898, 499);
            this.splitCon_userPermission.SplitterDistance = 71;
            this.splitCon_userPermission.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(737, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 31);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(178, 29);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(227, 19);
            this.txt_search.TabIndex = 1;
            this.txt_search.Visible = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by User Role : ";
            this.label1.Visible = false;
            // 
            // grd_userPermission
            // 
            this.grd_userPermission.AllowUserToAddRows = false;
            this.grd_userPermission.AllowUserToDeleteRows = false;
            this.grd_userPermission.AllowUserToOrderColumns = true;
            this.grd_userPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_userPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_userPermission.Location = new System.Drawing.Point(0, 0);
            this.grd_userPermission.Name = "grd_userPermission";
            this.grd_userPermission.RowTemplate.Height = 21;
            this.grd_userPermission.Size = new System.Drawing.Size(898, 424);
            this.grd_userPermission.TabIndex = 0;
            this.grd_userPermission.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grd_userPermission_DataBindingComplete);
            // 
            // FrmSetUserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 499);
            this.Controls.Add(this.pnl_data);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetUserPermission";
            this.Text = "Set User Permissions";
            this.Load += new System.EventHandler(this.frm_userPermissionLoad);
            this.pnl_data.ResumeLayout(false);
            this.splitCon_userPermission.Panel1.ResumeLayout(false);
            this.splitCon_userPermission.Panel1.PerformLayout();
            this.splitCon_userPermission.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCon_userPermission)).EndInit();
            this.splitCon_userPermission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_userPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.SplitContainer splitCon_userPermission;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_userPermission;
    }
}