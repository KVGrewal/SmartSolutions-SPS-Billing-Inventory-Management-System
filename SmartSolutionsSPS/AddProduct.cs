using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{

    public partial class AddProduct : Form
    {
        MainForm mf;

        static SqlConnection conn = ConnClass.getConnection();
    
        public AddProduct(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();      
        }


        #region
        /// <summary>
        /// BUTTON CLICK EVENT TO ADD A PRODUCT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHSCIN.Text.Trim()) || string.IsNullOrWhiteSpace(txtGST.Text.Trim()) || string.IsNullOrWhiteSpace(txtNAME.Text.Trim()) || string.IsNullOrWhiteSpace(txtBRAND.Text.Trim()))
            {
                MessageBox.Show("PLEASE FILL ALL FIELDS");
            }
            else
            {
                clsProduct product = new clsProduct();
                product.Product_name = txtNAME.Text.Trim();
                product.brand = txtBRAND.Text.Trim();
                int hsn, stock;
                decimal gst;
                int.TryParse(txtHSCIN.Text.Trim(), out hsn);
                //decimal.TryParse(txtPRICE.Text.Trim(), out price);
                decimal.TryParse(txtGST.Text.Trim(), out gst);
                product.hsn = hsn;
                product.gst = gst;
                //product.price = price;
                if (string.IsNullOrWhiteSpace(txtInitialStock.Text.Trim()) || string.IsNullOrEmpty(txtInitialStock.Text.Trim()))
                {
                    stock = 0;
                }
                else
                {
                    int.TryParse(txtInitialStock.Text.Trim(), out stock);
                }

                product.stock = stock;
                product.Add_Prod_Data();
                mf.childTriggerLoadNewForm(new AddProduct(mf));

            }

        }
        #endregion

    }
}


//hscin int
//gst decimal(2,2)
//name varchar(250)
//brand varchar(250)
//price decimal(10,2)