namespace InventoryManage.CLL
{
    partial class FrmEditItemType
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
            this.grd_editItemType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_editItemType
            // 
            this.grd_editItemType.AllowUserToAddRows = false;
            this.grd_editItemType.AllowUserToDeleteRows = false;
            this.grd_editItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editItemType.Location = new System.Drawing.Point(0, 0);
            this.grd_editItemType.Name = "grd_editItemType";
            this.grd_editItemType.ReadOnly = true;
            this.grd_editItemType.RowTemplate.Height = 21;
            this.grd_editItemType.Size = new System.Drawing.Size(784, 461);
            this.grd_editItemType.TabIndex = 0;
            this.grd_editItemType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editItemType_CellContentClick);
            // 
            // FrmEditItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grd_editItemType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditItemType";
            this.Text = "Edit Item Type";
            this.Load += new System.EventHandler(this.FrmEditItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItemType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_editItemType;
    }
}