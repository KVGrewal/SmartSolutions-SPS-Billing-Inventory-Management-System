using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{
    public partial class Bill : Form
    {
        private DataSet1 ds;

        public Bill(DataSet1 _ds)
        {
            InitializeComponent();
            ds = _ds;
        }

        private void Bill_Load(object sender, EventArgs e)
        {            
            try
            {
                reportViewerBill.LocalReport.ReportEmbeddedResource = "SmartSolutionsSPS.Report2.rdlc";



                reportViewerBill.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource(
                    "DataSet1",   // MUST match RDLC dataset name
                    ds.DataTable1.DefaultView);

                reportViewerBill.LocalReport.DataSources.Add(rds);
                reportDateTime.MaxDate = DateTime.Today;

                ReportParameter[] rp = new ReportParameter[1];
                rp[0] = new ReportParameter("ReportDate", reportDateTime.Value.ToString());
                reportViewerBill.LocalReport.SetParameters(rp);

                reportViewerBill.RefreshReport();                

                //reportViewerBill.SetDisplayMode(DisplayMode.PrintLayout);
                //reportViewerBill.ZoomMode = ZoomMode.PageWidth;
            }
            catch (Exception ex)
            { 
            }
            this.reportViewerBill.RefreshReport();
        }

        private void reportDateTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ReportParameter[] rp = new ReportParameter[1];
                rp[0] = new ReportParameter("ReportDate", reportDateTime.Value.ToString());
                reportViewerBill.LocalReport.SetParameters(rp);
                reportViewerBill.RefreshReport();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
