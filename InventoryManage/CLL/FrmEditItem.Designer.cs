namespace InventoryManage.CLL
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
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItem)).BeginInit();
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
            this.grd_editItem.Size = new System.Drawing.Size(834, 511);
            this.grd_editItem.TabIndex = 0;
            this.grd_editItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editItem_CellContentClick);
            // 
            // FrmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.grd_editItem);
            this.Name = "FrmEditItem";
            this.Text = "FrmEditItem";
            this.Load += new System.EventHandler(this.FrmEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_editItem;
    }
}