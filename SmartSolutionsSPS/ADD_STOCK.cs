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
    public partial class ADD_STOCK : Form
    {
        MainForm mf;
        public ADD_STOCK(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();
            showProducts();
        }

        //FUNCTION TO SHOW PRODUCTS
        private void showProducts()
        {            
            clsDashboard dashProducts = new clsDashboard();
            DataTable dt = dashProducts.showProducts();
            listBoxProducts.DataSource = dt;
            listBoxProducts.DisplayMember = "product_name";
            listBoxProducts.ValueMember = "product_name";
        }

        //INDEX CHANGE EVENT OF PRODUCT LIST BOX
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showBrand();            
        }

        //FUNCTION TO SHOW BRAND OF PRODUCT BY NAME
        private void showBrand()
        {
            clsDashboard dashBrand = new clsDashboard();
            DataTable dt = dashBrand.showBrand(listBoxProducts.Text.Trim());
            listBoxBrands.DataSource = dt;
            listBoxBrands.DisplayMember = "brand";
            listBoxBrands.ValueMember = "product_id";
        }

        //BUTTON CLICK EVENT TO UPDATE STOCK OF A PRODUCT
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(listBoxProducts.Text.Trim()) || string.IsNullOrEmpty(listBoxBrands.Text.Trim()))
            {
                MessageBox.Show("FILL ALL FIELDS");
            }
            else
            {
                clsProduct stock = new clsProduct();
                int quantity = (int)numericUpDownStock.Value;
                int id = Convert.ToInt32(listBoxBrands.SelectedValue);
                try
                {
                    int res = stock.updateStock(id, quantity);
                    if (res > 0)
                    {
                        MessageBox.Show("Stock Updated Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

    }
}
