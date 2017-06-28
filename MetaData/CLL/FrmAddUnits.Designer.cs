namespace MetaData.CLL
{
    partial class FrmAddUnits
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
            this.pnl_addUnits = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unitId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_addUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_addUnits
            // 
            this.pnl_addUnits.Controls.Add(this.btn_delete);
            this.pnl_addUnits.Controls.Add(this.btn_update);
            this.pnl_addUnits.Controls.Add(this.btn_cancel);
            this.pnl_addUnits.Controls.Add(this.btn_create);
            this.pnl_addUnits.Controls.Add(this.label2);
            this.pnl_addUnits.Controls.Add(this.txt_unitId);
            this.pnl_addUnits.Controls.Add(this.label5);
            this.pnl_addUnits.Controls.Add(this.txt_description);
            this.pnl_addUnits.Controls.Add(this.label1);
            this.pnl_addUnits.Controls.Add(this.txt_symbol);
            this.pnl_addUnits.Controls.Add(this.label3);
            this.pnl_addUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_addUnits.Location = new System.Drawing.Point(0, 0);
            this.pnl_addUnits.Name = "pnl_addUnits";
            this.pnl_addUnits.Size = new System.Drawing.Size(521, 364);
            this.pnl_addUnits.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_delete.Location = new System.Drawing.Point(408, 255);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 96;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_update.Location = new System.Drawing.Point(307, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 31);
            this.btn_update.TabIndex = 95;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_cancel.Location = new System.Drawing.Point(211, 255);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_cancel.TabIndex = 93;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_create.Location = new System.Drawing.Point(307, 255);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 31);
            this.btn_create.TabIndex = 94;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(193, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Add Measuring Units";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_unitId
            // 
            this.txt_unitId.Enabled = false;
            this.txt_unitId.Location = new System.Drawing.Point(171, 69);
            this.txt_unitId.Name = "txt_unitId";
            this.txt_unitId.Size = new System.Drawing.Size(211, 19);
            this.txt_unitId.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(35, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 91;
            this.label5.Text = "Unit ID :";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(171, 110);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(211, 19);
            this.txt_description.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 86;
            this.label1.Text = "Description :";
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(171, 146);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(211, 19);
            this.txt_symbol.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "Symbol :";
            // 
            // FrmAddUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(521, 364);
            this.Controls.Add(this.pnl_addUnits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUnits";
            this.Text = "Add Units";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddUnits_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddUnits_Load);
            this.pnl_addUnits.ResumeLayout(false);
            this.pnl_addUnits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_addUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_unitId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_create;
    }
}