namespace InventoryManage.CLL
{
    partial class FrmSelectDealer
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
            this.splt_selectDealer = new System.Windows.Forms.SplitContainer();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_selectDealer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splt_selectDealer)).BeginInit();
            this.splt_selectDealer.Panel1.SuspendLayout();
            this.splt_selectDealer.Panel2.SuspendLayout();
            this.splt_selectDealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectDealer)).BeginInit();
            this.SuspendLayout();
            // 
            // splt_selectDealer
            // 
            this.splt_selectDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_selectDealer.Location = new System.Drawing.Point(0, 0);
            this.splt_selectDealer.Name = "splt_selectDealer";
            this.splt_selectDealer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_selectDealer.Panel1
            // 
            this.splt_selectDealer.Panel1.Controls.Add(this.txt_search);
            this.splt_selectDealer.Panel1.Controls.Add(this.cmb_search);
            this.splt_selectDealer.Panel1.Controls.Add(this.label1);
            // 
            // splt_selectDealer.Panel2
            // 
            this.splt_selectDealer.Panel2.Controls.Add(this.grd_selectDealer);
            this.splt_selectDealer.Size = new System.Drawing.Size(622, 386);
            this.splt_selectDealer.SplitterDistance = 72;
            this.splt_selectDealer.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(258, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 19);
            this.txt_search.TabIndex = 5;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "ALL",
            "Dealer Name",
            "Company Name"});
            this.cmb_search.Location = new System.Drawing.Point(108, 25);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(131, 20);
            this.cmb_search.TabIndex = 4;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seach By :";
            // 
            // grd_selectDealer
            // 
            this.grd_selectDealer.AllowUserToAddRows = false;
            this.grd_selectDealer.AllowUserToDeleteRows = false;
            this.grd_selectDealer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_selectDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_selectDealer.Location = new System.Drawing.Point(0, 0);
            this.grd_selectDealer.Name = "grd_selectDealer";
            this.grd_selectDealer.ReadOnly = true;
            this.grd_selectDealer.RowTemplate.Height = 21;
            this.grd_selectDealer.Size = new System.Drawing.Size(622, 310);
            this.grd_selectDealer.TabIndex = 0;
            this.grd_selectDealer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_selectDealer_CellContentClick);
            // 
            // FrmSelectDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(622, 386);
            this.Controls.Add(this.splt_selectDealer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectDealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Dealer";
            this.splt_selectDealer.Panel1.ResumeLayout(false);
            this.splt_selectDealer.Panel1.PerformLayout();
            this.splt_selectDealer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_selectDealer)).EndInit();
            this.splt_selectDealer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectDealer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_selectDealer;
        private System.Windows.Forms.DataGridView grd_selectDealer;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label label1;
    }
}