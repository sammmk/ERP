namespace MetaData.CLL
{
    partial class FrmEditDealers
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
            this.pnl_editDealers = new System.Windows.Forms.Panel();
            this.grd_editDealer = new System.Windows.Forms.DataGridView();
            this.splt_editDealers = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_editDealers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splt_editDealers)).BeginInit();
            this.splt_editDealers.Panel1.SuspendLayout();
            this.splt_editDealers.Panel2.SuspendLayout();
            this.splt_editDealers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_editDealers
            // 
            this.pnl_editDealers.Controls.Add(this.splt_editDealers);
            this.pnl_editDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_editDealers.Location = new System.Drawing.Point(0, 0);
            this.pnl_editDealers.Name = "pnl_editDealers";
            this.pnl_editDealers.Size = new System.Drawing.Size(795, 543);
            this.pnl_editDealers.TabIndex = 0;
            // 
            // grd_editDealer
            // 
            this.grd_editDealer.AllowUserToAddRows = false;
            this.grd_editDealer.AllowUserToDeleteRows = false;
            this.grd_editDealer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editDealer.Location = new System.Drawing.Point(0, 0);
            this.grd_editDealer.Name = "grd_editDealer";
            this.grd_editDealer.ReadOnly = true;
            this.grd_editDealer.RowTemplate.Height = 21;
            this.grd_editDealer.Size = new System.Drawing.Size(795, 472);
            this.grd_editDealer.TabIndex = 0;
            this.grd_editDealer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editDealer_CellContentClick);
            // 
            // splt_editDealers
            // 
            this.splt_editDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_editDealers.Location = new System.Drawing.Point(0, 0);
            this.splt_editDealers.Name = "splt_editDealers";
            this.splt_editDealers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_editDealers.Panel1
            // 
            this.splt_editDealers.Panel1.Controls.Add(this.txt_search);
            this.splt_editDealers.Panel1.Controls.Add(this.cmb_search);
            this.splt_editDealers.Panel1.Controls.Add(this.label1);
            // 
            // splt_editDealers.Panel2
            // 
            this.splt_editDealers.Panel2.Controls.Add(this.grd_editDealer);
            this.splt_editDealers.Size = new System.Drawing.Size(795, 543);
            this.splt_editDealers.SplitterDistance = 67;
            this.splt_editDealers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seach By :";
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "<<Select>>",
            "ALL",
            "Dealer Name",
            "Company Name"});
            this.cmb_search.Location = new System.Drawing.Point(117, 24);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(131, 20);
            this.cmb_search.TabIndex = 1;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(267, 25);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 19);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // FrmEditDealers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(795, 543);
            this.Controls.Add(this.pnl_editDealers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditDealers";
            this.Text = "Edit Dealers";
            this.Load += new System.EventHandler(this.FrmEditDealers_Load);
            this.pnl_editDealers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editDealer)).EndInit();
            this.splt_editDealers.Panel1.ResumeLayout(false);
            this.splt_editDealers.Panel1.PerformLayout();
            this.splt_editDealers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_editDealers)).EndInit();
            this.splt_editDealers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_editDealers;
        private System.Windows.Forms.SplitContainer splt_editDealers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_editDealer;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}