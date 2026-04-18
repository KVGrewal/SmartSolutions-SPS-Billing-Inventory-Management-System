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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalesDataSet.showAllSales' table. You can move, or remove it, as needed.
            this.showAllSalesTableAdapter.Connection.ConnectionString = ConnClass.getConnectionString();         
            this.showAllSalesTableAdapter.Fill(this.SalesDataSet.showAllSales);

            this.reportViewer1.RefreshReport();
        }
    }
}
