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
    public partial class Form2 : Form
    {
        private DataSet1 ds = null;
        public Form2(DataSet1 _ds)
        {
            InitializeComponent();
            dataGridViewReport.DataSource = ds.DataTable1;
            ds = _ds;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource rds = new ReportDataSource("Tablix1", (System.Data.DataTable)ds.DataTable1);
                this.reportViewer1.RefreshReport();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"Form2%%%%%%");
            }        

            //this.reportViewer1.RefreshReport();            
            
        }
    }
}
