namespace MetaData.CLL
{
    partial class FrmEditItem
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
            this.grd_editItem = new System.Windows.Forms.DataGridView();
            this.splt_editItem = new System.Windows.Forms.SplitContainer();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splt_editItem)).BeginInit();
            this.splt_editItem.Panel1.SuspendLayout();
            this.splt_editItem.Panel2.SuspendLayout();
            this.splt_editItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_editItem
            // 
            this.grd_editItem.AllowUserToAddRows = false;
            this.grd_editItem.AllowUserToDeleteRows = false;
            this.grd_editItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editItem.Location = new System.Drawing.Point(0, 0);
            this.grd_editItem.Name = "grd_editItem";
            this.grd_editItem.ReadOnly = true;
            this.grd_editItem.RowTemplate.Height = 21;
            this.grd_editItem.Size = new System.Drawing.Size(834, 451);
            this.grd_editItem.TabIndex = 0;
            this.grd_editItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editItem_CellContentClick);
            // 
            // splt_editItem
            // 
            this.splt_editItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_editItem.Location = new System.Drawing.Point(0, 0);
            this.splt_editItem.Name = "splt_editItem";
            this.splt_editItem.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_editItem.Panel1
            // 
            this.splt_editItem.Panel1.Controls.Add(this.txt_search);
            this.splt_editItem.Panel1.Controls.Add(this.cmb_search);
            this.splt_editItem.Panel1.Controls.Add(this.label1);
            // 
            // splt_editItem.Panel2
            // 
            this.splt_editItem.Panel2.Controls.Add(this.grd_editItem);
            this.splt_editItem.Size = new System.Drawing.Size(834, 511);
            this.splt_editItem.SplitterDistance = 56;
            this.splt_editItem.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(268, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(205, 19);
            this.txt_search.TabIndex = 5;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "<<Select>>",
            "ALL",
            "Item Code",
            "Item Name"});
            this.cmb_search.Location = new System.Drawing.Point(118, 18);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(131, 20);
            this.cmb_search.TabIndex = 4;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seach By :";
            // 
            // FrmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.splt_editItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditItem";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.FrmEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItem)).EndInit();
            this.splt_editItem.Panel1.ResumeLayout(false);
            this.splt_editItem.Panel1.PerformLayout();
            this.splt_editItem.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_editItem)).EndInit();
            this.splt_editItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_editItem;
        private System.Windows.Forms.SplitContainer splt_editItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label label1;
    }
}