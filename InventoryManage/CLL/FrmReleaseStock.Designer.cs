namespace InventoryManage.CLL
{
    partial class FrmReleaseStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splt_releaseStock = new System.Windows.Forms.SplitContainer();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_billAmt = new System.Windows.Forms.TextBox();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_release = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_inStockQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_releaseQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_selectStockId = new System.Windows.Forms.Button();
            this.txt_itemId = new System.Windows.Forms.TextBox();
            this.txt_destinationId = new System.Windows.Forms.TextBox();
            this.dt_delivery = new System.Windows.Forms.DateTimePicker();
            this.btn_selectDestination = new System.Windows.Forms.Button();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_destName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stockEntryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_releaseId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_releaseStock = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_stockIdQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splt_releaseStock)).BeginInit();
            this.splt_releaseStock.Panel1.SuspendLayout();
            this.splt_releaseStock.Panel2.SuspendLayout();
            this.splt_releaseStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_releaseStock)).BeginInit();
            this.SuspendLayout();
            // 
            // splt_releaseStock
            // 
            this.splt_releaseStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_releaseStock.Location = new System.Drawing.Point(0, 0);
            this.splt_releaseStock.Name = "splt_releaseStock";
            this.splt_releaseStock.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splt_releaseStock.Panel1
            // 
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_stockIdQty);
            this.splt_releaseStock.Panel1.Controls.Add(this.label14);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_billAmt);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_comment);
            this.splt_releaseStock.Panel1.Controls.Add(this.label13);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_Cancel);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_release);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_add);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_clear);
            this.splt_releaseStock.Panel1.Controls.Add(this.label12);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_discount);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_inStockQty);
            this.splt_releaseStock.Panel1.Controls.Add(this.label11);
            this.splt_releaseStock.Panel1.Controls.Add(this.label10);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_total);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_releaseQty);
            this.splt_releaseStock.Panel1.Controls.Add(this.label9);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_selectStockId);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_itemId);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_destinationId);
            this.splt_releaseStock.Panel1.Controls.Add(this.dt_delivery);
            this.splt_releaseStock.Panel1.Controls.Add(this.btn_selectDestination);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_itemCode);
            this.splt_releaseStock.Panel1.Controls.Add(this.label8);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_destName);
            this.splt_releaseStock.Panel1.Controls.Add(this.label7);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_itemName);
            this.splt_releaseStock.Panel1.Controls.Add(this.label6);
            this.splt_releaseStock.Panel1.Controls.Add(this.label5);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_UnitPrice);
            this.splt_releaseStock.Panel1.Controls.Add(this.label4);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_stockEntryId);
            this.splt_releaseStock.Panel1.Controls.Add(this.label3);
            this.splt_releaseStock.Panel1.Controls.Add(this.txt_releaseId);
            this.splt_releaseStock.Panel1.Controls.Add(this.label2);
            this.splt_releaseStock.Panel1.Controls.Add(this.label1);
            // 
            // splt_releaseStock.Panel2
            // 
            this.splt_releaseStock.Panel2.Controls.Add(this.grd_releaseStock);
            this.splt_releaseStock.Size = new System.Drawing.Size(1041, 517);
            this.splt_releaseStock.SplitterDistance = 228;
            this.splt_releaseStock.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 52;
            this.label14.Text = "Total Bill Amount :";
            // 
            // txt_billAmt
            // 
            this.txt_billAmt.Enabled = false;
            this.txt_billAmt.Location = new System.Drawing.Point(435, 170);
            this.txt_billAmt.Name = "txt_billAmt";
            this.txt_billAmt.Size = new System.Drawing.Size(131, 19);
            this.txt_billAmt.TabIndex = 51;
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(110, 137);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(179, 52);
            this.txt_comment.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 49;
            this.label13.Text = "Comment :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Cancel.Location = new System.Drawing.Point(936, 117);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 48;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_release
            // 
            this.btn_release.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_release.Location = new System.Drawing.Point(936, 173);
            this.btn_release.Name = "btn_release";
            this.btn_release.Size = new System.Drawing.Size(75, 31);
            this.btn_release.TabIndex = 47;
            this.btn_release.Text = "Release";
            this.btn_release.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_add.Location = new System.Drawing.Point(936, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 31);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(936, 80);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 31);
            this.btn_clear.TabIndex = 45;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "Discount (%) :";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(435, 139);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(131, 19);
            this.txt_discount.TabIndex = 43;
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // txt_inStockQty
            // 
            this.txt_inStockQty.Enabled = false;
            this.txt_inStockQty.Location = new System.Drawing.Point(435, 109);
            this.txt_inStockQty.Name = "txt_inStockQty";
            this.txt_inStockQty.Size = new System.Drawing.Size(131, 19);
            this.txt_inStockQty.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 12);
            this.label11.TabIndex = 41;
            this.label11.Text = "In Stock Qty :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total Price :";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(723, 139);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(122, 19);
            this.txt_total.TabIndex = 39;
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress);
            this.txt_total.Leave += new System.EventHandler(this.txt_total_Leave);
            // 
            // txt_releaseQty
            // 
            this.txt_releaseQty.Location = new System.Drawing.Point(723, 109);
            this.txt_releaseQty.Name = "txt_releaseQty";
            this.txt_releaseQty.Size = new System.Drawing.Size(122, 19);
            this.txt_releaseQty.TabIndex = 38;
            this.txt_releaseQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_releaseQty_KeyPress);
            this.txt_releaseQty.Leave += new System.EventHandler(this.txt_releaseQty_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "Release Qty :";
            // 
            // btn_selectStockId
            // 
            this.btn_selectStockId.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_selectStockId.Location = new System.Drawing.Point(259, 107);
            this.btn_selectStockId.Name = "btn_selectStockId";
            this.btn_selectStockId.Size = new System.Drawing.Size(30, 19);
            this.btn_selectStockId.TabIndex = 36;
            this.btn_selectStockId.Text = "...";
            this.btn_selectStockId.UseVisualStyleBackColor = true;
            this.btn_selectStockId.Click += new System.EventHandler(this.btn_selectStockId_Click);
            // 
            // txt_itemId
            // 
            this.txt_itemId.Enabled = false;
            this.txt_itemId.Location = new System.Drawing.Point(567, 76);
            this.txt_itemId.Name = "txt_itemId";
            this.txt_itemId.Size = new System.Drawing.Size(29, 19);
            this.txt_itemId.TabIndex = 35;
            this.txt_itemId.Visible = false;
            // 
            // txt_destinationId
            // 
            this.txt_destinationId.Enabled = false;
            this.txt_destinationId.Location = new System.Drawing.Point(603, 44);
            this.txt_destinationId.Name = "txt_destinationId";
            this.txt_destinationId.Size = new System.Drawing.Size(21, 19);
            this.txt_destinationId.TabIndex = 34;
            this.txt_destinationId.Visible = false;
            // 
            // dt_delivery
            // 
            this.dt_delivery.Location = new System.Drawing.Point(724, 44);
            this.dt_delivery.Name = "dt_delivery";
            this.dt_delivery.Size = new System.Drawing.Size(121, 19);
            this.dt_delivery.TabIndex = 33;
            this.dt_delivery.Value = new System.DateTime(2017, 5, 22, 13, 39, 58, 0);
            // 
            // btn_selectDestination
            // 
            this.btn_selectDestination.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_selectDestination.Location = new System.Drawing.Point(567, 44);
            this.btn_selectDestination.Name = "btn_selectDestination";
            this.btn_selectDestination.Size = new System.Drawing.Size(30, 19);
            this.btn_selectDestination.TabIndex = 32;
            this.btn_selectDestination.Text = "...";
            this.btn_selectDestination.UseVisualStyleBackColor = true;
            this.btn_selectDestination.Click += new System.EventHandler(this.btn_selectDestination_Click);
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.Location = new System.Drawing.Point(110, 74);
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(143, 19);
            this.txt_itemCode.TabIndex = 14;
            this.txt_itemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_itemCode_KeyUp);
            this.txt_itemCode.Leave += new System.EventHandler(this.txt_itemCode_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Item Code :";
            // 
            // txt_destName
            // 
            this.txt_destName.Enabled = false;
            this.txt_destName.Location = new System.Drawing.Point(435, 44);
            this.txt_destName.Name = "txt_destName";
            this.txt_destName.Size = new System.Drawing.Size(131, 19);
            this.txt_destName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Destination";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Enabled = false;
            this.txt_itemName.Location = new System.Drawing.Point(435, 76);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(131, 19);
            this.txt_itemName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Delivery Date :";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(723, 76);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(122, 19);
            this.txt_UnitPrice.TabIndex = 6;
            this.txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitPrice_KeyPress);
            this.txt_UnitPrice.Leave += new System.EventHandler(this.txt_UnitPrice_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unit Price :";
            // 
            // txt_stockEntryId
            // 
            this.txt_stockEntryId.Enabled = false;
            this.txt_stockEntryId.Location = new System.Drawing.Point(110, 107);
            this.txt_stockEntryId.Name = "txt_stockEntryId";
            this.txt_stockEntryId.Size = new System.Drawing.Size(143, 19);
            this.txt_stockEntryId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Id :";
            // 
            // txt_releaseId
            // 
            this.txt_releaseId.Enabled = false;
            this.txt_releaseId.Location = new System.Drawing.Point(110, 42);
            this.txt_releaseId.Name = "txt_releaseId";
            this.txt_releaseId.Size = new System.Drawing.Size(143, 19);
            this.txt_releaseId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Release Stock";
            // 
            // grd_releaseStock
            // 
            this.grd_releaseStock.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_releaseStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_releaseStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_releaseStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemName,
            this.quantity,
            this.unitPrice,
            this.discount,
            this.subTotal,
            this.availableQty,
            this.afterQty,
            this.stockId,
            this.itemId,
            this.comment});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_releaseStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_releaseStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_releaseStock.Location = new System.Drawing.Point(0, 0);
            this.grd_releaseStock.Name = "grd_releaseStock";
            this.grd_releaseStock.RowTemplate.Height = 21;
            this.grd_releaseStock.Size = new System.Drawing.Size(1041, 285);
            this.grd_releaseStock.TabIndex = 0;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.Name = "itemCode";
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount (%)";
            this.discount.Name = "discount";
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            // 
            // availableQty
            // 
            this.availableQty.HeaderText = "Available Qty";
            this.availableQty.Name = "availableQty";
            // 
            // afterQty
            // 
            this.afterQty.HeaderText = "Remain Qty in Stock";
            this.afterQty.Name = "afterQty";
            // 
            // stockId
            // 
            this.stockId.HeaderText = "Stock Id";
            this.stockId.Name = "stockId";
            this.stockId.Visible = false;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item Id";
            this.itemId.Name = "itemId";
            this.itemId.Visible = false;
            // 
            // comment
            // 
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            // 
            // txt_stockIdQty
            // 
            this.txt_stockIdQty.Enabled = false;
            this.txt_stockIdQty.Location = new System.Drawing.Point(567, 109);
            this.txt_stockIdQty.Name = "txt_stockIdQty";
            this.txt_stockIdQty.Size = new System.Drawing.Size(29, 19);
            this.txt_stockIdQty.TabIndex = 53;
            this.txt_stockIdQty.Visible = false;
            // 
            // FrmReleaseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1041, 517);
            this.Controls.Add(this.splt_releaseStock);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReleaseStock";
            this.Text = "Release Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReleaseStock_FormClosing);
            this.Load += new System.EventHandler(this.FrmReleaseStock_Load);
            this.splt_releaseStock.Panel1.ResumeLayout(false);
            this.splt_releaseStock.Panel1.PerformLayout();
            this.splt_releaseStock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_releaseStock)).EndInit();
            this.splt_releaseStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_releaseStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splt_releaseStock;
        private System.Windows.Forms.TextBox txt_releaseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_releaseStock;
        private System.Windows.Forms.TextBox txt_itemCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_destName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stockEntryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_destinationId;
        private System.Windows.Forms.DateTimePicker dt_delivery;
        private System.Windows.Forms.Button btn_selectDestination;
        private System.Windows.Forms.TextBox txt_itemId;
        private System.Windows.Forms.TextBox txt_releaseQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_selectStockId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_inStockQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Button btn_release;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_billAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.TextBox txt_stockIdQty;
    }
}