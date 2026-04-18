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
    public partial class Statistics : Form
    {
        DataTable dt;
        DataView dv;

        clsStatistics st;
        public Statistics()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            try
            {
                getToCollect();
                getToPay();
                getTax();
                clsSales sale = new clsSales();
                dt = sale.fillData(0);
                dv = new DataView(dt);
            }
            catch (Exception ex)
            { 
            }            

        }

        //FUNCTION TO SHOW THE AMOUNT TO BE COLLECTED
        //CALLED BY SAME FUNCTION
        private void getToPay()
        {
            st = new clsStatistics();
            lblToPayAmt.Text = st.getToPay();            
        }

        //FUNCTION TO SHOW THE TAX TO BE PAID
        //CALLED BY SAME FUNCTION
        private void getTax()
        {
            //st = new clsStatistics();
            //labelTax.Text = st.getTax();            
        }

        //FUNCTION TO SHOW SALES TO THE USER
        private void showSales()
        {
            dataGridViewShowData.DataSource = dv;
            autoResize(dataGridViewShowData);            

        }

        //FUNCTION TO RESIZE GRIDVIEW
        private void autoResize(DataGridView dataGridView)
        {
            int height = dataGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                height += row.Height;
            }

            dataGridView.Height = height + 2;

            int width = dataGridView.RowHeadersWidth;

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                width += col.Width;
            }

            dataGridView.Width = width + 2;

        }


        //FUNCTION TO SHOW THE AMOUNT TO BE COLLECTED
        //CALLED BY SAME FUNCTION
        private void getToCollect()
        {
            st = new clsStatistics();
            lblToCollectAmt.Text = st.getToCollect();
        }

        //BUTTON TO VIEW SALES
        private void buttonAlllSales_Click(object sender, EventArgs e)
        {
            dataGridViewShowData.Visible = true;
            showSales();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("sfjklsadfhaj");
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Empty;
            showSales();
        }

        private void radioButtonPaid_CheckedChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "amount = paid_amt";
            showSales();
        }

        private void radioButtonUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "amount > paid_amt";
            showSales();
        }


    }
}
