namespace SmartSolutionsSPS
{
    partial class Add_Purchases
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
            this.comboP_NAME = new System.Windows.Forms.ComboBox();
            this.comboP_BRAND = new System.Windows.Forms.ComboBox();
            this.QUANTITY = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBILL = new System.Windows.Forms.TextBox();
            this.lblSUPP = new System.Windows.Forms.Label();
            this.txtSUPP = new System.Windows.Forms.TextBox();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPurchasedProducts = new System.Windows.Forms.DataGridView();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPaid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // comboP_NAME
            // 
            this.comboP_NAME.FormattingEnabled = true;
            this.comboP_NAME.Location = new System.Drawing.Point(281, 19);
            this.comboP_NAME.Name = "comboP_NAME";
            this.comboP_NAME.Size = new System.Drawing.Size(217, 21);
            this.comboP_NAME.TabIndex = 0;
            this.comboP_NAME.Text = "PRODUCT NAME";
            this.comboP_NAME.SelectedIndexChanged += new System.EventHandler(this.comboP_NAME_SelectedIndexChanged);
            // 
            // comboP_BRAND
            // 
            this.comboP_BRAND.FormattingEnabled = true;
            this.comboP_BRAND.Location = new System.Drawing.Point(281, 66);
            this.comboP_BRAND.Name = "comboP_BRAND";
            this.comboP_BRAND.Size = new System.Drawing.Size(217, 21);
            this.comboP_BRAND.TabIndex = 1;
            this.comboP_BRAND.Text = "BRAND";
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSize = true;
            this.QUANTITY.Location = new System.Drawing.Point(105, 115);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(62, 13);
            this.QUANTITY.TabIndex = 2;
            this.QUANTITY.Text = "QUANTITY";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(298, 265);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(51, 13);
            this.lblBill.TabIndex = 4;
            this.lblBill.Text = "BILL NO.";
            // 
            // txtBILL
            // 
            this.txtBILL.Location = new System.Drawing.Point(281, 324);
            this.txtBILL.Name = "txtBILL";
            this.txtBILL.Size = new System.Drawing.Size(100, 20);
            this.txtBILL.TabIndex = 0;
            // 
            // lblSUPP
            // 
            this.lblSUPP.AutoSize = true;
            this.lblSUPP.Location = new System.Drawing.Point(557, 265);
            this.lblSUPP.Name = "lblSUPP";
            this.lblSUPP.Size = new System.Drawing.Size(111, 13);
            this.lblSUPP.TabIndex = 6;
            this.lblSUPP.Text = "NAME OF SUPPLIER";
            // 
            // txtSUPP
            // 
            this.txtSUPP.Location = new System.Drawing.Point(550, 324);
            this.txtSUPP.Name = "txtSUPP";
            this.txtSUPP.Size = new System.Drawing.Size(100, 20);
            this.txtSUPP.TabIndex = 1;
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.BackColor = System.Drawing.Color.Maroon;
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.Location = new System.Drawing.Point(410, 454);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(210, 38);
            this.btnAddPurchase.TabIndex = 5;
            this.btnAddPurchase.Text = "SUBMIT";
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownQuantity);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboP_NAME);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.comboP_BRAND);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.QUANTITY);
            this.groupBox1.Location = new System.Drawing.Point(200, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT DETAILS";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(281, 115);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "BRAND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(281, 162);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(110, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "PRICE";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(772, 43);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 3;
            // 
            // dataGridViewPurchasedProducts
            // 
            this.dataGridViewPurchasedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchasedProducts.Location = new System.Drawing.Point(200, 507);
            this.dataGridViewPurchasedProducts.Name = "dataGridViewPurchasedProducts";
            this.dataGridViewPurchasedProducts.Size = new System.Drawing.Size(450, 89);
            this.dataGridViewPurchasedProducts.TabIndex = 14;
            this.dataGridViewPurchasedProducts.Visible = false;
            this.dataGridViewPurchasedProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchasedProducts_CellContentClick);
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(789, 324);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaid.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(402, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(789, 264);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(93, 13);
            this.lblPaid.TabIndex = 17;
            this.lblPaid.Text = "PAID AMOUNT";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.dataGridViewPurchasedProducts);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddPurchase);
            this.Controls.Add(this.txtSUPP);
            this.Controls.Add(this.lblSUPP);
            this.Controls.Add(this.txtBILL);
            this.Controls.Add(this.lblBill);
            this.Name = "Add_Purchases";
            this.Text = "Purchases";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboP_NAME;
        private System.Windows.Forms.ComboBox comboP_BRAND;
        private System.Windows.Forms.Label QUANTITY;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBILL;
        private System.Windows.Forms.Label lblSUPP;
        private System.Windows.Forms.TextBox txtSUPP;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.DataGridView dataGridViewPurchasedProducts;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label lblPaid;
    }
}