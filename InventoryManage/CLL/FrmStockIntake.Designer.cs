namespace InventoryManage.CLL
{
    partial class FrmStockIntake
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
            this.splt_stockIntake = new System.Windows.Forms.SplitContainer();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_totalValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime_expire = new System.Windows.Forms.DateTimePicker();
            this.dateTime_stockEntry = new System.Windows.Forms.DateTimePicker();
            this.txt_expireDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_stockEntryDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sellUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_buyUnitPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_itemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_entryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_stockCurrent = new System.Windows.Forms.DataGridView();
            this.txt_priceAfterDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splt_stockIntake)).BeginInit();
            this.splt_stockIntake.Panel1.SuspendLayout();
            this.splt_stockIntake.Panel2.SuspendLayout();
            this.splt_stockIntake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // splt_stockIntake
            // 
            this.splt_stockIntake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_stockIntake.Location = new System.Drawing.Point(0, 0);
            this.splt_stockIntake.Name = "splt_stockIntake";
            this.splt_stockIntake.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_stockIntake.Panel1
            // 
            this.splt_stockIntake.Panel1.Controls.Add(this.label13);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_comment);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_priceAfterDiscount);
            this.splt_stockIntake.Panel1.Controls.Add(this.label12);
            this.splt_stockIntake.Panel1.Controls.Add(this.btn_clear);
            this.splt_stockIntake.Panel1.Controls.Add(this.btn_add);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_totalValue);
            this.splt_stockIntake.Panel1.Controls.Add(this.label11);
            this.splt_stockIntake.Panel1.Controls.Add(this.dateTime_expire);
            this.splt_stockIntake.Panel1.Controls.Add(this.dateTime_stockEntry);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_expireDate);
            this.splt_stockIntake.Panel1.Controls.Add(this.label10);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_stockEntryDate);
            this.splt_stockIntake.Panel1.Controls.Add(this.label9);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_sellUnitPrice);
            this.splt_stockIntake.Panel1.Controls.Add(this.label8);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_buyUnitPrice);
            this.splt_stockIntake.Panel1.Controls.Add(this.label7);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_quantity);
            this.splt_stockIntake.Panel1.Controls.Add(this.label6);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_itemName);
            this.splt_stockIntake.Panel1.Controls.Add(this.label5);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_itemId);
            this.splt_stockIntake.Panel1.Controls.Add(this.label4);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_itemCode);
            this.splt_stockIntake.Panel1.Controls.Add(this.label3);
            this.splt_stockIntake.Panel1.Controls.Add(this.txt_entryId);
            this.splt_stockIntake.Panel1.Controls.Add(this.label2);
            this.splt_stockIntake.Panel1.Controls.Add(this.label1);
            // 
            // splt_stockIntake.Panel2
            // 
            this.splt_stockIntake.Panel2.Controls.Add(this.grd_stockCurrent);
            this.splt_stockIntake.Size = new System.Drawing.Size(1018, 606);
            this.splt_stockIntake.SplitterDistance = 263;
            this.splt_stockIntake.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(904, 217);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 30);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(771, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 30);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_totalValue
            // 
            this.txt_totalValue.Location = new System.Drawing.Point(380, 189);
            this.txt_totalValue.Name = "txt_totalValue";
            this.txt_totalValue.Size = new System.Drawing.Size(146, 19);
            this.txt_totalValue.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Value :";
            // 
            // dateTime_expire
            // 
            this.dateTime_expire.Location = new System.Drawing.Point(532, 155);
            this.dateTime_expire.Name = "dateTime_expire";
            this.dateTime_expire.Size = new System.Drawing.Size(103, 19);
            this.dateTime_expire.TabIndex = 20;
            this.dateTime_expire.ValueChanged += new System.EventHandler(this.dateTime_expire_ValueChanged);
            // 
            // dateTime_stockEntry
            // 
            this.dateTime_stockEntry.Location = new System.Drawing.Point(532, 121);
            this.dateTime_stockEntry.Name = "dateTime_stockEntry";
            this.dateTime_stockEntry.Size = new System.Drawing.Size(103, 19);
            this.dateTime_stockEntry.TabIndex = 19;
            this.dateTime_stockEntry.ValueChanged += new System.EventHandler(this.dateTime_stockEntry_ValueChanged);
            // 
            // txt_expireDate
            // 
            this.txt_expireDate.Location = new System.Drawing.Point(380, 155);
            this.txt_expireDate.Name = "txt_expireDate";
            this.txt_expireDate.Size = new System.Drawing.Size(146, 19);
            this.txt_expireDate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Expiration Date :";
            // 
            // txt_stockEntryDate
            // 
            this.txt_stockEntryDate.Location = new System.Drawing.Point(380, 121);
            this.txt_stockEntryDate.Name = "txt_stockEntryDate";
            this.txt_stockEntryDate.Size = new System.Drawing.Size(146, 19);
            this.txt_stockEntryDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stock Entry Date :";
            // 
            // txt_sellUnitPrice
            // 
            this.txt_sellUnitPrice.Location = new System.Drawing.Point(380, 87);
            this.txt_sellUnitPrice.Name = "txt_sellUnitPrice";
            this.txt_sellUnitPrice.Size = new System.Drawing.Size(146, 19);
            this.txt_sellUnitPrice.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Selling Unit Price :";
            // 
            // txt_buyUnitPrice
            // 
            this.txt_buyUnitPrice.Location = new System.Drawing.Point(380, 53);
            this.txt_buyUnitPrice.Name = "txt_buyUnitPrice";
            this.txt_buyUnitPrice.Size = new System.Drawing.Size(146, 19);
            this.txt_buyUnitPrice.TabIndex = 12;
            this.txt_buyUnitPrice.Leave += new System.EventHandler(this.txt_buyUnitPrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buying Unit Price :";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(91, 189);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(146, 19);
            this.txt_quantity.TabIndex = 10;
            this.txt_quantity.Leave += new System.EventHandler(this.txt_quantity_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity :";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(91, 155);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(146, 19);
            this.txt_itemName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Name :";
            // 
            // txt_itemId
            // 
            this.txt_itemId.Enabled = false;
            this.txt_itemId.Location = new System.Drawing.Point(91, 121);
            this.txt_itemId.Name = "txt_itemId";
            this.txt_itemId.Size = new System.Drawing.Size(146, 19);
            this.txt_itemId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Id :";
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.Location = new System.Drawing.Point(91, 87);
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(146, 19);
            this.txt_itemCode.TabIndex = 4;
            this.txt_itemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_itemCode_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Code :";
            // 
            // txt_entryId
            // 
            this.txt_entryId.Enabled = false;
            this.txt_entryId.Location = new System.Drawing.Point(91, 53);
            this.txt_entryId.Name = "txt_entryId";
            this.txt_entryId.Size = new System.Drawing.Size(146, 19);
            this.txt_entryId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entry Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(356, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grd_stockCurrent
            // 
            this.grd_stockCurrent.AllowUserToAddRows = false;
            this.grd_stockCurrent.AllowUserToDeleteRows = false;
            this.grd_stockCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_stockCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_stockCurrent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grd_stockCurrent.Location = new System.Drawing.Point(0, 0);
            this.grd_stockCurrent.Name = "grd_stockCurrent";
            this.grd_stockCurrent.ReadOnly = true;
            this.grd_stockCurrent.RowTemplate.Height = 21;
            this.grd_stockCurrent.Size = new System.Drawing.Size(1018, 339);
            this.grd_stockCurrent.TabIndex = 0;
            this.grd_stockCurrent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_stockCurrent_CellContentClick);
            // 
            // txt_priceAfterDiscount
            // 
            this.txt_priceAfterDiscount.Location = new System.Drawing.Point(771, 53);
            this.txt_priceAfterDiscount.Name = "txt_priceAfterDiscount";
            this.txt_priceAfterDiscount.Size = new System.Drawing.Size(146, 19);
            this.txt_priceAfterDiscount.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(649, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "Price After Discount :";
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(771, 87);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(208, 66);
            this.txt_comment.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(649, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "Comment :";
            // 
            // FrmStockIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1018, 606);
            this.Controls.Add(this.splt_stockIntake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockIntake";
            this.Text = "Stock Intake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStockIntake_FormClosing);
            this.Load += new System.EventHandler(this.FrmStockIntake_Load);
            this.splt_stockIntake.Panel1.ResumeLayout(false);
            this.splt_stockIntake.Panel1.PerformLayout();
            this.splt_stockIntake.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_stockIntake)).EndInit();
            this.splt_stockIntake.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_stockIntake;
        private System.Windows.Forms.DateTimePicker dateTime_expire;
        private System.Windows.Forms.DateTimePicker dateTime_stockEntry;
        private System.Windows.Forms.TextBox txt_expireDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_stockEntryDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sellUnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_buyUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_itemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_itemCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_entryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_stockCurrent;
        private System.Windows.Forms.TextBox txt_totalValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.TextBox txt_priceAfterDiscount;
        private System.Windows.Forms.Label label12;
    }
}