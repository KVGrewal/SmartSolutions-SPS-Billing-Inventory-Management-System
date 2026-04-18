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
    public partial class Add_Purchases : Form
    {
        MainForm mf;
        BindingList<clsOrder> list = new BindingList<clsOrder>();
        DataTable dt;
        //static SqlConnection conn = ConnClass.getConnection();
        public Add_Purchases(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();
            load_data();
            dataGridViewPurchasedProducts.DataSource = list;
            dataGridViewPurchasedProducts.Columns["prod_id"].Visible = false;
            dataGridViewPurchasedProducts.Columns["hsn"].Visible = false;
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "Action";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewPurchasedProducts.Columns.Add(btnDelete);
        }

        #region
        /// <summary>
        /// FUNCTIONS TO SHOW PRODUCTS
        /// </summary>
        protected void load_data()
        {
            clsDashboard dashProducts = new clsDashboard();
            dt = dashProducts.showProducts();
            comboP_NAME.DataSource = dt;
            comboP_NAME.DisplayMember = "product_name";
            comboP_NAME.ValueMember = "product_name";
            comboP_NAME.SelectedIndex = -1;
        }

       

        private void comboP_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {            
            clsDashboard dashBrand = new clsDashboard();
            dt = dashBrand.showBrand(comboP_NAME.Text.Trim());
            comboP_BRAND.DataSource = dt;
            comboP_BRAND.DisplayMember = "brand";
            comboP_BRAND.ValueMember = "product_id";
            //dataGridView1.DataSource = dt;            
        }

        #endregion


        #region
        /// <summary>
        /// BUTTON CLICK EVENT TO ADD PURCHASE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            clsPurchases purchase = new clsPurchases();
            
            
            purchase.bill = txtBILL.Text.Trim();
            purchase.supplier = txtSUPP.Text.Trim();
            purchase.purchase_date = dateTimePickerPurchaseDate.Value.Date;            
            decimal paid;                        
            decimal.TryParse(textBoxPaid.Text.Trim(), out paid);                      
            purchase.paid = paid;
            if (purchase.bill == null || purchase.supplier == null || string.IsNullOrWhiteSpace(textBoxPaid.Text.Trim()))
            {
                MessageBox.Show("ALL COLUMNS ARE REQUIERED TO FILL");
            }
            else
            {
                try
                {
                    purchase.addPurchase(list);
                    mf.childTriggerLoadNewForm(new Add_Purchases(mf));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }



        }
        #endregion

        //BUTTON CLICK EVENT TO ADD MULTIPLE PRODUCTS IN A PURCHASE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBILL.Text.Trim()))
            {
                MessageBox.Show("PLEASE FILL THE BILL NUMBER");
            }
            else
            {
                if (dataGridViewPurchasedProducts.Visible == false)
                {
                    dataGridViewPurchasedProducts.Visible = true;
                }
                clsOrder order = new clsOrder();
                int index = (int)comboP_BRAND.SelectedIndex;
                decimal price;
                decimal.TryParse(textBoxPrice.Text.Trim(), out price);
                order.Bill_no = txtBILL.Text.Trim();
                order.Quantity = (int)numericUpDownQuantity.Value;
                order.prod_id = (int)dt.Rows[index]["product_id"];
                order.Price = price;

                order.setProperties(order.prod_id);
                list.Add(order);
                load_data();
            }

            
        }

        private void dataGridViewPurchasedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the clicked cell is in the Delete button column
            if (dataGridViewPurchasedProducts.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                // Get the corresponding object
                var Order = dataGridViewPurchasedProducts.Rows[e.RowIndex].DataBoundItem as clsOrder;
                if (Order != null)
                {
                    list.Remove(Order); // Automatically removes the row from the grid

                }
            }
        }
        

    }
}
