namespace SmartSolutionsSPS
{
    partial class Dashboard
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
            this.cmbC_name = new System.Windows.Forms.ComboBox();
            this.cmbC_Add = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.txtPartialPayment = new System.Windows.Forms.TextBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddMoreItems = new System.Windows.Forms.Button();
            this.dataGridViewSelectedProducts = new System.Windows.Forms.DataGridView();
            this.lblPanelCustomer = new System.Windows.Forms.Label();
            this.lblPanelCustomerNameDisp = new System.Windows.Forms.Label();
            this.lblPanelTaxableAmount = new System.Windows.Forms.Label();
            this.lblPanelTaxableAmountDisp = new System.Windows.Forms.Label();
            this.lblPanelCgst = new System.Windows.Forms.Label();
            this.lblPanelSgst = new System.Windows.Forms.Label();
            this.lblPanelAmount = new System.Windows.Forms.Label();
            this.lblPanelPaid = new System.Windows.Forms.Label();
            this.lblPanelCgstDisp = new System.Windows.Forms.Label();
            this.lblPanelSgstDisp = new System.Windows.Forms.Label();
            this.lblPanelTotalAmountDisp = new System.Windows.Forms.Label();
            this.lblPanelPaidDisp = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblPanelDateDisp = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblStocks = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxBrand = new System.Windows.Forms.ListBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotalAmt = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbC_name
            // 
            this.cmbC_name.DropDownWidth = 121;
            this.cmbC_name.FormattingEnabled = true;
            this.cmbC_name.Location = new System.Drawing.Point(18, 37);
            this.cmbC_name.Name = "cmbC_name";
            this.cmbC_name.Size = new System.Drawing.Size(121, 24);
            this.cmbC_name.TabIndex = 0;
            this.cmbC_name.SelectedIndexChanged += new System.EventHandler(this.cmbC_name_SelectedIndexChanged);
            // 
            // cmbC_Add
            // 
            this.cmbC_Add.DropDownWidth = 600;
            this.cmbC_Add.FormattingEnabled = true;
            this.cmbC_Add.Location = new System.Drawing.Point(18, 93);
            this.cmbC_Add.Name = "cmbC_Add";
            this.cmbC_Add.Size = new System.Drawing.Size(121, 24);
            this.cmbC_Add.TabIndex = 1;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Location = new System.Drawing.Point(287, 39);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(121, 23);
            this.lblPaymentStatus.TabIndex = 9;
            this.lblPaymentStatus.Text = "PAYMENT STATUS";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(202, 37);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbPaymentStatus.TabIndex = 10;
            this.cmbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentStatus_SelectedIndexChanged);
            // 
            // txtPartialPayment
            // 
            this.txtPartialPayment.Enabled = false;
            this.txtPartialPayment.Location = new System.Drawing.Point(203, 94);
            this.txtPartialPayment.Name = "txtPartialPayment";
            this.txtPartialPayment.Size = new System.Drawing.Size(120, 23);
            this.txtPartialPayment.TabIndex = 15;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(1113, 466);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(121, 23);
            this.btnSummary.TabIndex = 16;
            this.btnSummary.Text = "VIEW SUMMARY";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1123, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2026, 3, 12, 11, 35, 22, 0);
            // 
            // btnAddMoreItems
            // 
            this.btnAddMoreItems.Location = new System.Drawing.Point(664, 116);
            this.btnAddMoreItems.Name = "btnAddMoreItems";
            this.btnAddMoreItems.Size = new System.Drawing.Size(120, 23);
            this.btnAddMoreItems.TabIndex = 21;
            this.btnAddMoreItems.Text = "ADD";
            this.btnAddMoreItems.UseVisualStyleBackColor = true;
            this.btnAddMoreItems.Click += new System.EventHandler(this.btnAddMoreItems_Click);
            // 
            // dataGridViewSelectedProducts
            // 
            this.dataGridViewSelectedProducts.AllowUserToAddRows = false;
            this.dataGridViewSelectedProducts.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedProducts.AllowUserToResizeColumns = false;
            this.dataGridViewSelectedProducts.AllowUserToResizeRows = false;
            this.dataGridViewSelectedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSelectedProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSelectedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedProducts.Location = new System.Drawing.Point(64, 355);
            this.dataGridViewSelectedProducts.Name = "dataGridViewSelectedProducts";
            this.dataGridViewSelectedProducts.ReadOnly = true;
            this.dataGridViewSelectedProducts.Size = new System.Drawing.Size(668, 150);
            this.dataGridViewSelectedProducts.TabIndex = 22;
            this.dataGridViewSelectedProducts.Visible = false;
            // 
            // lblPanelCustomer
            // 
            this.lblPanelCustomer.AutoSize = true;
            this.lblPanelCustomer.Location = new System.Drawing.Point(125, 47);
            this.lblPanelCustomer.Name = "lblPanelCustomer";
            this.lblPanelCustomer.Size = new System.Drawing.Size(68, 13);
            this.lblPanelCustomer.TabIndex = 0;
            this.lblPanelCustomer.Text = "CUSTOMER";
            this.lblPanelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPanelCustomerNameDisp
            // 
            this.lblPanelCustomerNameDisp.AutoSize = true;
            this.lblPanelCustomerNameDisp.Location = new System.Drawing.Point(336, 50);
            this.lblPanelCustomerNameDisp.Name = "lblPanelCustomerNameDisp";
            this.lblPanelCustomerNameDisp.Size = new System.Drawing.Size(180, 13);
            this.lblPanelCustomerNameDisp.TabIndex = 1;
            this.lblPanelCustomerNameDisp.Text = "NAME WILL BE DISPLAYED HERE";
            // 
            // lblPanelTaxableAmount
            // 
            this.lblPanelTaxableAmount.AutoSize = true;
            this.lblPanelTaxableAmount.Location = new System.Drawing.Point(125, 247);
            this.lblPanelTaxableAmount.Name = "lblPanelTaxableAmount";
            this.lblPanelTaxableAmount.Size = new System.Drawing.Size(105, 13);
            this.lblPanelTaxableAmount.TabIndex = 10;
            this.lblPanelTaxableAmount.Text = "TAXABLE AMOUNT";
            // 
            // lblPanelTaxableAmountDisp
            // 
            this.lblPanelTaxableAmountDisp.AutoSize = true;
            this.lblPanelTaxableAmountDisp.Location = new System.Drawing.Point(336, 247);
            this.lblPanelTaxableAmountDisp.Name = "lblPanelTaxableAmountDisp";
            this.lblPanelTaxableAmountDisp.Size = new System.Drawing.Size(247, 13);
            this.lblPanelTaxableAmountDisp.TabIndex = 11;
            this.lblPanelTaxableAmountDisp.Text = "TAXABLE AMOUNT WILL BE DISPLAYED HERE";
            // 
            // lblPanelCgst
            // 
            this.lblPanelCgst.AutoSize = true;
            this.lblPanelCgst.Location = new System.Drawing.Point(125, 288);
            this.lblPanelCgst.Name = "lblPanelCgst";
            this.lblPanelCgst.Size = new System.Drawing.Size(36, 13);
            this.lblPanelCgst.TabIndex = 12;
            this.lblPanelCgst.Text = "CGST";
            // 
            // lblPanelSgst
            // 
            this.lblPanelSgst.AutoSize = true;
            this.lblPanelSgst.Location = new System.Drawing.Point(125, 318);
            this.lblPanelSgst.Name = "lblPanelSgst";
            this.lblPanelSgst.Size = new System.Drawing.Size(36, 13);
            this.lblPanelSgst.TabIndex = 13;
            this.lblPanelSgst.Text = "SGST";
            // 
            // lblPanelAmount
            // 
            this.lblPanelAmount.AutoSize = true;
            this.lblPanelAmount.Location = new System.Drawing.Point(125, 345);
            this.lblPanelAmount.Name = "lblPanelAmount";
            this.lblPanelAmount.Size = new System.Drawing.Size(92, 13);
            this.lblPanelAmount.TabIndex = 14;
            this.lblPanelAmount.Text = "TOTAL AMOUNT";
            // 
            // lblPanelPaid
            // 
            this.lblPanelPaid.AutoSize = true;
            this.lblPanelPaid.Location = new System.Drawing.Point(132, 387);
            this.lblPanelPaid.Name = "lblPanelPaid";
            this.lblPanelPaid.Size = new System.Drawing.Size(32, 13);
            this.lblPanelPaid.TabIndex = 15;
            this.lblPanelPaid.Text = "PAID";
            // 
            // lblPanelCgstDisp
            // 
            this.lblPanelCgstDisp.AutoSize = true;
            this.lblPanelCgstDisp.Location = new System.Drawing.Point(336, 288);
            this.lblPanelCgstDisp.Name = "lblPanelCgstDisp";
            this.lblPanelCgstDisp.Size = new System.Drawing.Size(36, 13);
            this.lblPanelCgstDisp.TabIndex = 16;
            this.lblPanelCgstDisp.Text = "CGST";
            // 
            // lblPanelSgstDisp
            // 
            this.lblPanelSgstDisp.AutoSize = true;
            this.lblPanelSgstDisp.Location = new System.Drawing.Point(336, 318);
            this.lblPanelSgstDisp.Name = "lblPanelSgstDisp";
            this.lblPanelSgstDisp.Size = new System.Drawing.Size(36, 13);
            this.lblPanelSgstDisp.TabIndex = 17;
            this.lblPanelSgstDisp.Text = "SGST";
            // 
            // lblPanelTotalAmountDisp
            // 
            this.lblPanelTotalAmountDisp.AutoSize = true;
            this.lblPanelTotalAmountDisp.Location = new System.Drawing.Point(336, 345);
            this.lblPanelTotalAmountDisp.Name = "lblPanelTotalAmountDisp";
            this.lblPanelTotalAmountDisp.Size = new System.Drawing.Size(92, 13);
            this.lblPanelTotalAmountDisp.TabIndex = 18;
            this.lblPanelTotalAmountDisp.Text = "TOTAL AMOUNT";
            // 
            // lblPanelPaidDisp
            // 
            this.lblPanelPaidDisp.AutoSize = true;
            this.lblPanelPaidDisp.Location = new System.Drawing.Point(336, 387);
            this.lblPanelPaidDisp.Name = "lblPanelPaidDisp";
            this.lblPanelPaidDisp.Size = new System.Drawing.Size(82, 13);
            this.lblPanelPaidDisp.TabIndex = 19;
            this.lblPanelPaidDisp.Text = "PAID AMOUNT";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(620, 439);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.Text = "GO BACK";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblPanelDateDisp
            // 
            this.lblPanelDateDisp.AutoSize = true;
            this.lblPanelDateDisp.Location = new System.Drawing.Point(635, 32);
            this.lblPanelDateDisp.Name = "lblPanelDateDisp";
            this.lblPanelDateDisp.Size = new System.Drawing.Size(36, 13);
            this.lblPanelDateDisp.TabIndex = 21;
            this.lblPanelDateDisp.Text = "DATE";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(83, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE TRANSACTION";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblPanelDateDisp);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.lblPanelPaidDisp);
            this.panel1.Controls.Add(this.lblPanelTotalAmountDisp);
            this.panel1.Controls.Add(this.lblPanelSgstDisp);
            this.panel1.Controls.Add(this.lblPanelCgstDisp);
            this.panel1.Controls.Add(this.lblPanelPaid);
            this.panel1.Controls.Add(this.lblPanelAmount);
            this.panel1.Controls.Add(this.lblPanelSgst);
            this.panel1.Controls.Add(this.lblPanelCgst);
            this.panel1.Controls.Add(this.lblPanelTaxableAmountDisp);
            this.panel1.Controls.Add(this.lblPanelTaxableAmount);
            this.panel1.Controls.Add(this.lblPanelCustomerNameDisp);
            this.panel1.Controls.Add(this.lblPanelCustomer);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(204, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 510);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 146);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(121, 23);
            this.btnAddCustomer.TabIndex = 23;
            this.btnAddCustomer.Text = "PROCEED";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbC_name);
            this.groupBox1.Controls.Add(this.cmbC_Add);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.cmbPaymentStatus);
            this.groupBox1.Controls.Add(this.txtPartialPayment);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 303);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.lblStocks);
            this.groupBox2.Controls.Add(this.textBoxPrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.listBoxProducts);
            this.groupBox2.Controls.Add(this.listBoxBrand);
            this.groupBox2.Controls.Add(this.numericUpDownQuantity);
            this.groupBox2.Controls.Add(this.btnAddMoreItems);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(118, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 203);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(28, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 23);
            this.textBoxSearch.TabIndex = 29;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Location = new System.Drawing.Point(497, 102);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(141, 17);
            this.lblStocks.TabIndex = 28;
            this.lblStocks.Text = "AVAILABLE STOCKS";
            this.lblStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(664, 67);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(120, 23);
            this.textBoxPrice.TabIndex = 27;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(699, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 17);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "PRICE";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(497, 20);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 17);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "QUANTITY";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(28, 44);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(251, 84);
            this.listBoxProducts.TabIndex = 23;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // listBoxBrand
            // 
            this.listBoxBrand.FormattingEnabled = true;
            this.listBoxBrand.ItemHeight = 16;
            this.listBoxBrand.Location = new System.Drawing.Point(362, 20);
            this.listBoxBrand.Name = "listBoxBrand";
            this.listBoxBrand.Size = new System.Drawing.Size(120, 84);
            this.listBoxBrand.TabIndex = 22;
            this.listBoxBrand.SelectedIndexChanged += new System.EventHandler(this.listBoxBrand_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(500, 55);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownQuantity.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblOrderTotalAmt);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(667, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(577, 73);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ORDER TOTAL";
            this.groupBox5.Visible = false;
            // 
            // lblOrderTotalAmt
            // 
            this.lblOrderTotalAmt.AutoSize = true;
            this.lblOrderTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalAmt.Location = new System.Drawing.Point(145, 49);
            this.lblOrderTotalAmt.Name = "lblOrderTotalAmt";
            this.lblOrderTotalAmt.Size = new System.Drawing.Size(25, 20);
            this.lblOrderTotalAmt.TabIndex = 1;
            this.lblOrderTotalAmt.Text = "kk";
            this.lblOrderTotalAmt.Visible = false;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Location = new System.Drawing.Point(1113, 434);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateBill.TabIndex = 26;
            this.btnGenerateBill.Text = "GENERATE BILL";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSelectedProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblPaymentStatus);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbC_name;
        private System.Windows.Forms.ComboBox cmbC_Add;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.TextBox txtPartialPayment;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddMoreItems;
        private System.Windows.Forms.DataGridView dataGridViewSelectedProducts;
        private System.Windows.Forms.Label lblPanelCustomer;
        private System.Windows.Forms.Label lblPanelCustomerNameDisp;
        private System.Windows.Forms.Label lblPanelTaxableAmount;
        private System.Windows.Forms.Label lblPanelTaxableAmountDisp;
        private System.Windows.Forms.Label lblPanelCgst;
        private System.Windows.Forms.Label lblPanelSgst;
        private System.Windows.Forms.Label lblPanelAmount;
        private System.Windows.Forms.Label lblPanelPaid;
        private System.Windows.Forms.Label lblPanelCgstDisp;
        private System.Windows.Forms.Label lblPanelSgstDisp;
        private System.Windows.Forms.Label lblPanelTotalAmountDisp;
        private System.Windows.Forms.Label lblPanelPaidDisp;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblPanelDateDisp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ListBox listBoxBrand;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblOrderTotalAmt;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}                                                                                                                                                                                 