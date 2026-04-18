namespace SmartSolutionsSPS
{
    partial class VIEW_SALES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.pnlUpdateSale = new System.Windows.Forms.Panel();
            this.dateAddPayment = new System.Windows.Forms.DateTimePicker();
            this.btnCancelSaleUpdate = new System.Windows.Forms.Button();
            this.btnConfirmSaleUpdate = new System.Windows.Forms.Button();
            this.txtPanelPaid = new System.Windows.Forms.TextBox();
            this.lblSaleUpdate = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnPrintSalesReport = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.pnlUpdateSale.SuspendLayout();
            this.SuspendLayout();

            // ================= FORM =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "SALES DASHBOARD";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ================= SALES GRID =================
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSales.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewSales.MultiSelect = false;
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(960, 170);
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSales.EnableHeadersVisualStyles = false;
            this.dataGridViewSales.RowHeadersVisible = false;
            this.dataGridViewSales.GridColor = System.Drawing.Color.LightGray;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = headerStyle;

            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSales.DefaultCellStyle = dataGridViewCellStyle2;

            this.dataGridViewSales.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 248, 255);

            this.dataGridViewSales.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // ================= DETAILS GRID =================
            this.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetails.Location = new System.Drawing.Point(12, 300);
            this.dataGridViewDetails.Size = new System.Drawing.Size(960, 150);
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewDetails.RowHeadersVisible = false;
            this.dataGridViewDetails.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewDetails.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridViewDetails.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 248, 255);

            // ================= UPDATE PANEL =================
            this.pnlUpdateSale.BackColor = System.Drawing.Color.White;
            this.pnlUpdateSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateSale.Location = new System.Drawing.Point(293, 150);
            this.pnlUpdateSale.Size = new System.Drawing.Size(349, 250);
            this.pnlUpdateSale.Visible = false;

            this.lblSaleUpdate.Text = "ENTER THE AMOUNT PAID";
            this.lblSaleUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaleUpdate.Location = new System.Drawing.Point(60, 25);
            this.lblSaleUpdate.AutoSize = true;

            this.txtPanelPaid.Location = new System.Drawing.Point(100, 75);
            this.txtPanelPaid.Size = new System.Drawing.Size(150, 23);

            this.dateAddPayment.Location = new System.Drawing.Point(100, 115);
            this.dateAddPayment.Size = new System.Drawing.Size(150, 23);

            // Confirm Button
            this.btnConfirmSaleUpdate.Text = "CONFIRM";
            this.btnConfirmSaleUpdate.Location = new System.Drawing.Point(40, 180);
            this.btnConfirmSaleUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnConfirmSaleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSaleUpdate.FlatAppearance.BorderSize = 0;
            this.btnConfirmSaleUpdate.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnConfirmSaleUpdate.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSaleUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSaleUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmSaleUpdate.Click +=
                new System.EventHandler(this.btnConfirmSaleUpdate_Click);

            // Cancel Button
            this.btnCancelSaleUpdate.Text = "CANCEL";
            this.btnCancelSaleUpdate.Location = new System.Drawing.Point(190, 180);
            this.btnCancelSaleUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnCancelSaleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSaleUpdate.FlatAppearance.BorderSize = 0;
            this.btnCancelSaleUpdate.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelSaleUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCancelSaleUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelSaleUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSaleUpdate.Click +=
                new System.EventHandler(this.btnCancelSaleUpdate_Click);

            this.pnlUpdateSale.Controls.Add(this.lblSaleUpdate);
            this.pnlUpdateSale.Controls.Add(this.txtPanelPaid);
            this.pnlUpdateSale.Controls.Add(this.dateAddPayment);
            this.pnlUpdateSale.Controls.Add(this.btnConfirmSaleUpdate);
            this.pnlUpdateSale.Controls.Add(this.btnCancelSaleUpdate);

            // ================= FILTER COMBO =================
            this.comboBoxFilter.Location = new System.Drawing.Point(1049, 112);
            this.comboBoxFilter.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilter.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);

            // ================= ACTION BUTTONS =================
            this.btnGenerateBill.Text = "GENERATE BILL";
            this.btnGenerateBill.Location = new System.Drawing.Point(1049, 170);
            this.btnGenerateBill.Size = new System.Drawing.Size(150, 35);
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.Click +=
                new System.EventHandler(this.btnGenerateBill_Click);

            this.btnPrintSalesReport.Text = "PRINT SALES REPORT";
            this.btnPrintSalesReport.Location = new System.Drawing.Point(1049, 215);
            this.btnPrintSalesReport.Size = new System.Drawing.Size(150, 35);
            this.btnPrintSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalesReport.FlatAppearance.BorderSize = 0;
            this.btnPrintSalesReport.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnPrintSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintSalesReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSalesReport.Click +=
                new System.EventHandler(this.btnPrintSalesReport_Click);

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.pnlUpdateSale);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnPrintSalesReport);

            this.Load += new System.EventHandler(this.VIEW_SALES_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.pnlUpdateSale.ResumeLayout(false);
            this.pnlUpdateSale.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Panel pnlUpdateSale;
        private System.Windows.Forms.Button btnCancelSaleUpdate;
        private System.Windows.Forms.Button btnConfirmSaleUpdate;
        private System.Windows.Forms.TextBox txtPanelPaid;
        private System.Windows.Forms.Label lblSaleUpdate;
        private System.Windows.Forms.DateTimePicker dateAddPayment;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnPrintSalesReport;
        //private SSDataSet SSDataSet;
        //private SSDataSetTableAdapters.showProductsTableAdapter showProductsTableAdapter;

    }
}