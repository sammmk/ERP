namespace InventoryManage.CLL
{
    partial class FrmEditStockIntake
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
            this.pnl_editStock = new System.Windows.Forms.Panel();
            this.splt_editStock = new System.Windows.Forms.SplitContainer();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.chk_itemCode = new System.Windows.Forms.CheckBox();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.grd_editStockEntry = new System.Windows.Forms.DataGridView();
            this.pnl_editStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_editStock)).BeginInit();
            this.splt_editStock.Panel1.SuspendLayout();
            this.splt_editStock.Panel2.SuspendLayout();
            this.splt_editStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editStockEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_editStock
            // 
            this.pnl_editStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_editStock.Controls.Add(this.splt_editStock);
            this.pnl_editStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_editStock.Location = new System.Drawing.Point(0, 0);
            this.pnl_editStock.Name = "pnl_editStock";
            this.pnl_editStock.Size = new System.Drawing.Size(927, 480);
            this.pnl_editStock.TabIndex = 0;
            // 
            // splt_editStock
            // 
            this.splt_editStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_editStock.Location = new System.Drawing.Point(0, 0);
            this.splt_editStock.Name = "splt_editStock";
            this.splt_editStock.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_editStock.Panel1
            // 
            this.splt_editStock.Panel1.Controls.Add(this.btn_search);
            this.splt_editStock.Panel1.Controls.Add(this.txt_itemCode);
            this.splt_editStock.Panel1.Controls.Add(this.chk_itemCode);
            this.splt_editStock.Panel1.Controls.Add(this.chk_all);
            this.splt_editStock.Panel1.Controls.Add(this.label3);
            this.splt_editStock.Panel1.Controls.Add(this.label2);
            this.splt_editStock.Panel1.Controls.Add(this.dt_to);
            this.splt_editStock.Panel1.Controls.Add(this.chk_date);
            this.splt_editStock.Panel1.Controls.Add(this.dt_from);
            // 
            // splt_editStock.Panel2
            // 
            this.splt_editStock.Panel2.Controls.Add(this.grd_editStockEntry);
            this.splt_editStock.Size = new System.Drawing.Size(927, 480);
            this.splt_editStock.SplitterDistance = 98;
            this.splt_editStock.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(688, 63);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 36);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.Location = new System.Drawing.Point(195, 80);
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(276, 19);
            this.txt_itemCode.TabIndex = 9;
            this.txt_itemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_itemCode_KeyUp);
            this.txt_itemCode.Leave += new System.EventHandler(this.txt_itemCode_Leave);
            // 
            // chk_itemCode
            // 
            this.chk_itemCode.AutoSize = true;
            this.chk_itemCode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_itemCode.Location = new System.Drawing.Point(18, 83);
            this.chk_itemCode.Name = "chk_itemCode";
            this.chk_itemCode.Size = new System.Drawing.Size(106, 16);
            this.chk_itemCode.TabIndex = 8;
            this.chk_itemCode.Text = "By Item Code";
            this.chk_itemCode.UseVisualStyleBackColor = true;
            this.chk_itemCode.CheckedChanged += new System.EventHandler(this.chk_itemCode_CheckedChanged);
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_all.Location = new System.Drawing.Point(18, 12);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(74, 16);
            this.chk_all.TabIndex = 7;
            this.chk_all.Text = "All Data";
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(324, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(145, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "From :";
            // 
            // dt_to
            // 
            this.dt_to.Location = new System.Drawing.Point(358, 44);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(113, 19);
            this.dt_to.TabIndex = 2;
            // 
            // chk_date
            // 
            this.chk_date.AutoSize = true;
            this.chk_date.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_date.Location = new System.Drawing.Point(18, 47);
            this.chk_date.Name = "chk_date";
            this.chk_date.Size = new System.Drawing.Size(73, 16);
            this.chk_date.TabIndex = 0;
            this.chk_date.Text = "By Date";
            this.chk_date.UseVisualStyleBackColor = true;
            this.chk_date.CheckedChanged += new System.EventHandler(this.chk_date_CheckedChanged);
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(195, 43);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(113, 19);
            this.dt_from.TabIndex = 1;
            // 
            // grd_editStockEntry
            // 
            this.grd_editStockEntry.AllowUserToAddRows = false;
            this.grd_editStockEntry.AllowUserToDeleteRows = false;
            this.grd_editStockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editStockEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editStockEntry.Location = new System.Drawing.Point(0, 0);
            this.grd_editStockEntry.Name = "grd_editStockEntry";
            this.grd_editStockEntry.ReadOnly = true;
            this.grd_editStockEntry.RowTemplate.Height = 21;
            this.grd_editStockEntry.Size = new System.Drawing.Size(927, 378);
            this.grd_editStockEntry.TabIndex = 0;
            this.grd_editStockEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editStockEntry_CellContentClick);
            // 
            // FrmEditStockIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 480);
            this.Controls.Add(this.pnl_editStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditStockIntake";
            this.Text = "Edit Stock Intake";
            this.Load += new System.EventHandler(this.FrmEditStockIntake_Load);
            this.pnl_editStock.ResumeLayout(false);
            this.splt_editStock.Panel1.ResumeLayout(false);
            this.splt_editStock.Panel1.PerformLayout();
            this.splt_editStock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_editStock)).EndInit();
            this.splt_editStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editStockEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_editStock;
        private System.Windows.Forms.DataGridView grd_editStockEntry;
        private System.Windows.Forms.SplitContainer splt_editStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.CheckBox chk_all;
        private System.Windows.Forms.TextBox txt_itemCode;
        private System.Windows.Forms.CheckBox chk_itemCode;
        private System.Windows.Forms.Button btn_search;
    }
}