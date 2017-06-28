namespace MetaData.CLL
{
    partial class FrmEditTax
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
            this.grd_editTax = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.grd_editTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_editTax
            // 
            this.grd_editTax.AllowUserToAddRows = false;
            this.grd_editTax.AllowUserToDeleteRows = false;
            this.grd_editTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_editTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_editTax.Location = new System.Drawing.Point(0, 0);
            this.grd_editTax.Name = "grd_editTax";
            this.grd_editTax.ReadOnly = true;
            this.grd_editTax.RowTemplate.Height = 21;
            this.grd_editTax.Size = new System.Drawing.Size(639, 373);
            this.grd_editTax.TabIndex = 0;
            this.grd_editTax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_editTax_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd_editTax);
            this.splitContainer1.Size = new System.Drawing.Size(639, 430);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 1;
            // 
            // FrmEditTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(639, 430);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditTax";
            this.Text = "Edit Tax";
            this.Load += new System.EventHandler(this.FrmEditTax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_editTax)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_editTax;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}