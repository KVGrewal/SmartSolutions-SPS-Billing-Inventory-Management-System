namespace SmartSolutionsSPS
{
    partial class SalesReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.showAllSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesDataSet = new SmartSolutionsSPS.SalesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.showAllSalesTableAdapter = new SmartSolutionsSPS.SalesDataSetTableAdapters.showAllSalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.showAllSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllSalesBindingSource
            // 
            this.showAllSalesBindingSource.DataMember = "showAllSales";
            this.showAllSalesBindingSource.DataSource = this.SalesDataSet;
            // 
            // SalesDataSet
            // 
            this.SalesDataSet.DataSetName = "SalesDataSet";
            this.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.showAllSalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartSolutionsSPS.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1283, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // showAllSalesTableAdapter
            // 
            this.showAllSalesTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showAllSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource showAllSalesBindingSource;
        private SalesDataSet SalesDataSet;
        private SalesDataSetTableAdapters.showAllSalesTableAdapter showAllSalesTableAdapter;
    }
}