namespace InventoryManage.CLL
{
    partial class FrmSelectDestination
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_selectDestination = new System.Windows.Forms.DataGridView();
            this.btn_addDestination = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_addDestination);
            this.splitContainer1.Panel1.Controls.Add(this.txt_search);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_search);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd_selectDestination);
            this.splitContainer1.Size = new System.Drawing.Size(589, 413);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(257, 22);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(186, 19);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "ALL",
            "Destination Name",
            "Owner Name"});
            this.cmb_search.Location = new System.Drawing.Point(107, 21);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(131, 20);
            this.cmb_search.TabIndex = 7;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seach By :";
            // 
            // grd_selectDestination
            // 
            this.grd_selectDestination.AllowUserToAddRows = false;
            this.grd_selectDestination.AllowUserToDeleteRows = false;
            this.grd_selectDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_selectDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_selectDestination.Location = new System.Drawing.Point(0, 0);
            this.grd_selectDestination.Name = "grd_selectDestination";
            this.grd_selectDestination.ReadOnly = true;
            this.grd_selectDestination.RowTemplate.Height = 21;
            this.grd_selectDestination.Size = new System.Drawing.Size(589, 337);
            this.grd_selectDestination.TabIndex = 0;
            this.grd_selectDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_selectDestination_CellContentClick);
            // 
            // btn_addDestination
            // 
            this.btn_addDestination.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_addDestination.Location = new System.Drawing.Point(463, 41);
            this.btn_addDestination.Name = "btn_addDestination";
            this.btn_addDestination.Size = new System.Drawing.Size(114, 28);
            this.btn_addDestination.TabIndex = 9;
            this.btn_addDestination.Text = "Add Destination";
            this.btn_addDestination.UseVisualStyleBackColor = true;
            this.btn_addDestination.Click += new System.EventHandler(this.btn_addDestination_Click);
            // 
            // FrmSelectDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(589, 413);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectDestination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Destination";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_selectDestination;
        private System.Windows.Forms.Button btn_addDestination;
    }
}