using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection(); 

        public Form1()
        {
            InitializeComponent();
        }
        

        public void Auto()
        {

            clsDashboard objDesh = new clsDashboard();
            
            DataTable cdt = new DataTable();

            cdt = objDesh.fillCustomer();

            if (cdt.Rows.Count > 0)
            {

                for (int i = 0; i < cdt.Rows.Count; i++)
                {

                    coll.Add(cdt.Rows[i]["customer_name"].ToString());

                }

            }
            else
            {

                MessageBox.Show("Name not found");

            }

            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBox1.AutoCompleteCustomSource = coll;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Auto();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clsDashboard objDesh1 = new clsDashboard();

            DataTable CData = new DataTable();

            objDesh1._CName = textBox1.Text.Trim();

            CData = objDesh1.getCustomer();

            //richTextBox1.Text = CData.Rows[0]["customer_address"].ToString(); 
            comboBox1.DataSource =CData;
            comboBox1.DisplayMember = "customer_address";
            comboBox1.ValueMember = "customer_id";            
        }  
    }
}
