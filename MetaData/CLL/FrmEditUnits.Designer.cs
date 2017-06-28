namespace MetaData.CLL
{
    partial class FrmEditUnits
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
            this.splt_editUnits = new System.Windows.Forms.SplitContainer();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_editUnits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splt_editUnits)).BeginInit();
            this.splt_editUnits.Panel1.SuspendLayout();
            this.splt_editUnits.Panel2.SuspendLayout();
            this.splt_editUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // splt_editUnits
            // 
            this.splt_editUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_editUnits.Location = new System.Drawing.Point(0, 0);
            this.splt_editUnits.Name = "splt_editUnits";
            this.splt_editUnits.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_editUnits.Panel1
            // 
            this.splt_editUnits.Panel1.Controls.Add(this.txt_search);
            this.splt_editUnits.Panel1.Controls.Add(this.cmb_search);
            this.splt_editUnits.Panel1.Controls.Add(this.label1);
            // 
            // splt_editUnits.Panel2
            // 
            this.splt_editUnits.Panel2.Controls.Add(this.grd_editUnits);
            this.splt_editUnits.Size = new System.Drawing.Size(670, 400);
            this.splt_editUnits.SplitterDistance = 47;
            this.splt_editUnits.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(267, 25);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 19);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "<<Select>>",
            "ALL",
            "Description"});
            this.cmb_search.Location = new System.Drawing.Point(117, 24);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(131, 20);
            this.cmb_search.TabIndex = 1;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
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
            // grd_editUnits
            // 
            this.grd_editUnits.AllowUserToAddRows = false;
            this.grd_editUnits.AllowUserToDeleteRows = false;
            this.grd_editUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editUnits.Location = new System.Drawing.Point(0, 0);
            this.grd_editUnits.Name = "grd_editUnits";
            this.grd_editUnits.ReadOnly = true;
            this.grd_editUnits.RowTemplate.Height = 21;
            this.grd_editUnits.Size = new System.Drawing.Size(670, 349);
            this.grd_editUnits.TabIndex = 0;
            this.grd_editUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editUnits_CellContentClick);
            // 
            // FrmEditUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this.splt_editUnits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditUnits";
            this.Text = "Edit Units";
            this.Load += new System.EventHandler(this.FrmEditUnits_Load);
            this.splt_editUnits.Panel1.ResumeLayout(false);
            this.splt_editUnits.Panel1.PerformLayout();
            this.splt_editUnits.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_editUnits)).EndInit();
            this.splt_editUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_editUnits;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_editUnits;
    }
}