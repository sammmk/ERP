namespace InventoryManage.CLL
{
    partial class FrmSelectStockEntry
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
            this.lbl_shortage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_releaseQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_selectStockEntry = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectStockEntry)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbl_shortage);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_releaseQty);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_totalQty);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd_selectStockEntry);
            this.splitContainer1.Size = new System.Drawing.Size(711, 411);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_shortage
            // 
            this.lbl_shortage.AutoSize = true;
            this.lbl_shortage.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_shortage.Location = new System.Drawing.Point(575, 29);
            this.lbl_shortage.Name = "lbl_shortage";
            this.lbl_shortage.Size = new System.Drawing.Size(15, 14);
            this.lbl_shortage.TabIndex = 5;
            this.lbl_shortage.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(493, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Shortage :";
            // 
            // lbl_releaseQty
            // 
            this.lbl_releaseQty.AutoSize = true;
            this.lbl_releaseQty.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_releaseQty.Location = new System.Drawing.Point(378, 29);
            this.lbl_releaseQty.Name = "lbl_releaseQty";
            this.lbl_releaseQty.Size = new System.Drawing.Size(15, 14);
            this.lbl_releaseQty.TabIndex = 3;
            this.lbl_releaseQty.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(273, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Release Qty :";
            // 
            // lbl_totalQty
            // 
            this.lbl_totalQty.AutoSize = true;
            this.lbl_totalQty.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_totalQty.Location = new System.Drawing.Point(159, 29);
            this.lbl_totalQty.Name = "lbl_totalQty";
            this.lbl_totalQty.Size = new System.Drawing.Size(15, 14);
            this.lbl_totalQty.TabIndex = 1;
            this.lbl_totalQty.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Qty in Stock :";
            // 
            // grd_selectStockEntry
            // 
            this.grd_selectStockEntry.AllowUserToAddRows = false;
            this.grd_selectStockEntry.AllowUserToDeleteRows = false;
            this.grd_selectStockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_selectStockEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_selectStockEntry.Location = new System.Drawing.Point(0, 0);
            this.grd_selectStockEntry.Name = "grd_selectStockEntry";
            this.grd_selectStockEntry.RowTemplate.Height = 21;
            this.grd_selectStockEntry.Size = new System.Drawing.Size(711, 338);
            this.grd_selectStockEntry.TabIndex = 0;
            this.grd_selectStockEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_selectStockEntry_CellContentClick);
            this.grd_selectStockEntry.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grd_selectStockEntry_DataBindingComplete);
            // 
            // FrmSelectStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(711, 411);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectStockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Stock Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelectStockEntry_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_selectStockEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grd_selectStockEntry;
        private System.Windows.Forms.Label lbl_totalQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_shortage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_releaseQty;
        private System.Windows.Forms.Label label4;
    }
}