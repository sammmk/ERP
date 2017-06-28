namespace MetaData.CLL
{
    partial class FrmAddTax
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_taxPercentage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dateTime_to = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_from = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_timePeriod = new System.Windows.Forms.CheckBox();
            this.grp_duration = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grp_duration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_duration);
            this.panel1.Controls.Add(this.chk_timePeriod);
            this.panel1.Controls.Add(this.txt_taxPercentage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_symbol);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_taxId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 430);
            this.panel1.TabIndex = 0;
            // 
            // txt_taxPercentage
            // 
            this.txt_taxPercentage.Location = new System.Drawing.Point(152, 176);
            this.txt_taxPercentage.Name = "txt_taxPercentage";
            this.txt_taxPercentage.Size = new System.Drawing.Size(156, 19);
            this.txt_taxPercentage.TabIndex = 15;
            this.txt_taxPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_taxPercentage_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(48, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tax % :";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_delete.Location = new System.Drawing.Point(233, 339);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_update.Location = new System.Drawing.Point(152, 339);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 34);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_add.Location = new System.Drawing.Point(152, 339);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 34);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTime_to
            // 
            this.dateTime_to.Location = new System.Drawing.Point(122, 55);
            this.dateTime_to.Name = "dateTime_to";
            this.dateTime_to.Size = new System.Drawing.Size(156, 19);
            this.dateTime_to.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Effective To :";
            // 
            // dateTime_from
            // 
            this.dateTime_from.Location = new System.Drawing.Point(122, 18);
            this.dateTime_from.Name = "dateTime_from";
            this.dateTime_from.Size = new System.Drawing.Size(156, 19);
            this.dateTime_from.TabIndex = 8;
            this.dateTime_from.ValueChanged += new System.EventHandler(this.dateTime_from_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Effective From :";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(152, 139);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(156, 19);
            this.txt_description.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(48, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description :";
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(152, 104);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(156, 19);
            this.txt_symbol.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Symbol :";
            // 
            // txt_taxId
            // 
            this.txt_taxId.Enabled = false;
            this.txt_taxId.Location = new System.Drawing.Point(152, 72);
            this.txt_taxId.Name = "txt_taxId";
            this.txt_taxId.Size = new System.Drawing.Size(156, 19);
            this.txt_taxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(208, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Tax";
            // 
            // chk_timePeriod
            // 
            this.chk_timePeriod.AutoSize = true;
            this.chk_timePeriod.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_timePeriod.Location = new System.Drawing.Point(50, 214);
            this.chk_timePeriod.Name = "chk_timePeriod";
            this.chk_timePeriod.Size = new System.Drawing.Size(119, 16);
            this.chk_timePeriod.TabIndex = 16;
            this.chk_timePeriod.Text = "Define Duration";
            this.chk_timePeriod.UseVisualStyleBackColor = true;
            this.chk_timePeriod.CheckedChanged += new System.EventHandler(this.chk_timePeriod_CheckedChanged);
            // 
            // grp_duration
            // 
            this.grp_duration.Controls.Add(this.label5);
            this.grp_duration.Controls.Add(this.dateTime_from);
            this.grp_duration.Controls.Add(this.label6);
            this.grp_duration.Controls.Add(this.dateTime_to);
            this.grp_duration.Location = new System.Drawing.Point(30, 236);
            this.grp_duration.Name = "grp_duration";
            this.grp_duration.Size = new System.Drawing.Size(295, 97);
            this.grp_duration.TabIndex = 17;
            this.grp_duration.TabStop = false;
            // 
            // FrmAddTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(425, 430);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddTax";
            this.Text = "Add Tax";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddTax_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddTax_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_duration.ResumeLayout(false);
            this.grp_duration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dateTime_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_taxPercentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grp_duration;
        private System.Windows.Forms.CheckBox chk_timePeriod;
    }
}