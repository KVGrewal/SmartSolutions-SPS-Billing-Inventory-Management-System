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
    public partial class SHOW : Form
    {
        public SHOW()
        {
            InitializeComponent();
        }

        private void SHOW_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSDataSet.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.sSDataSet.tbl_product);

        }
    }
}
