namespace SmartSolutionsSPS
{
    partial class INVENTORY
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateGst = new System.Windows.Forms.Button();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHSN = new System.Windows.Forms.ComboBox();
            this.numericUpDownnNewRate = new System.Windows.Forms.NumericUpDown();
            this.lblNewRate = new System.Windows.Forms.Label();
            this.lblCurrnetSlabDisp = new System.Windows.Forms.Label();
            this.lblCurrentSlab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnNewRate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();

            // ================= FORM =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Text = "INVENTORY DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Allow resizing
            this.MinimumSize = new System.Drawing.Size(1000, 700);

            // ================= DATAGRIDVIEW =================
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(184, 126);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(608, 250);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;

            // ================= GROUPBOX 1 =================
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            this.groupBox1.Text = "GST SLAB MANAGEMENT";
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80);
            this.groupBox1.Location = new System.Drawing.Point(845, 126);
            this.groupBox1.Size = new System.Drawing.Size(310, 438);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);

            this.cmbHSN.Location = new System.Drawing.Point(32, 45);
            this.cmbHSN.Size = new System.Drawing.Size(200, 23);
            this.cmbHSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHSN.SelectedIndexChanged += new System.EventHandler(this.cmbHSN_SelectedIndexChanged);

            this.lblCurrentSlab.Text = "CURRENT SLAB";
            this.lblCurrentSlab.Location = new System.Drawing.Point(32, 110);
            this.lblCurrentSlab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblCurrnetSlabDisp.Location = new System.Drawing.Point(32, 140);
            this.lblCurrnetSlabDisp.AutoSize = true;

            this.lblNewRate.Text = "NEW RATE";
            this.lblNewRate.Location = new System.Drawing.Point(32, 200);
            this.lblNewRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.numericUpDownnNewRate.Location = new System.Drawing.Point(32, 230);
            this.numericUpDownnNewRate.Size = new System.Drawing.Size(120, 23);

            this.groupBox1.Controls.Add(this.cmbHSN);
            this.groupBox1.Controls.Add(this.lblCurrentSlab);
            this.groupBox1.Controls.Add(this.lblCurrnetSlabDisp);
            this.groupBox1.Controls.Add(this.lblNewRate);
            this.groupBox1.Controls.Add(this.numericUpDownnNewRate);

            // ================= GROUPBOX 2 =================
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            this.groupBox2.Text = "PRODUCT OPTIONS";
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80);
            this.groupBox2.Location = new System.Drawing.Point(184, 400);
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15);

            this.btnUpdateGst.Text = "UPDATE GST SLAB";
            this.btnUpdateGst.Location = new System.Drawing.Point(20, 40);
            this.btnUpdateGst.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateGst.Click += new System.EventHandler(this.btnEditGstSlab);

            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.Location = new System.Drawing.Point(20, 100);
            this.btnAddProduct.Size = new System.Drawing.Size(150, 35);
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);

            this.groupBox2.Controls.Add(this.btnUpdateGst);
            this.groupBox2.Controls.Add(this.btnAddProduct);

            // ================= GROUPBOX 3 =================
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            this.groupBox3.Text = "STOCK OPTIONS";
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80);
            this.groupBox3.Location = new System.Drawing.Point(593, 400);
            this.groupBox3.Size = new System.Drawing.Size(220, 170);
            this.groupBox3.Padding = new System.Windows.Forms.Padding(15);

            this.btnManageStock.Text = "MANAGE STOCK";
            this.btnManageStock.Location = new System.Drawing.Point(30, 40);
            this.btnManageStock.Size = new System.Drawing.Size(150, 35);
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);

            this.btnRemoveProduct.Text = "REMOVE PRODUCT";
            this.btnRemoveProduct.Location = new System.Drawing.Point(30, 100);
            this.btnRemoveProduct.Size = new System.Drawing.Size(150, 35);
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);

            this.groupBox3.Controls.Add(this.btnManageStock);
            this.groupBox3.Controls.Add(this.btnRemoveProduct);

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownnNewRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateGst;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownnNewRate;
        private System.Windows.Forms.Label lblNewRate;
        private System.Windows.Forms.Label lblCurrnetSlabDisp;
        private System.Windows.Forms.Label lblCurrentSlab;
        private System.Windows.Forms.ComboBox cmbHSN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}