namespace SmartSolutionsSPS
{
    partial class Bill
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
            this.reportViewerBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewerBill
            // 
            this.reportViewerBill.Location = new System.Drawing.Point(13, 13);
            this.reportViewerBill.Name = "reportViewerBill";
            this.reportViewerBill.Size = new System.Drawing.Size(1290, 536);
            this.reportViewerBill.TabIndex = 0;
            // 
            // reportDateTime
            // 
            this.reportDateTime.Location = new System.Drawing.Point(1120, 81);
            this.reportDateTime.Name = "reportDateTime";
            this.reportDateTime.Size = new System.Drawing.Size(165, 20);
            this.reportDateTime.TabIndex = 1;
            this.reportDateTime.ValueChanged += new System.EventHandler(this.reportDateTime_ValueChanged);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 561);
            this.Controls.Add(this.reportDateTime);
            this.Controls.Add(this.reportViewerBill);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBill;
        private System.Windows.Forms.DateTimePicker reportDateTime;
    }
}