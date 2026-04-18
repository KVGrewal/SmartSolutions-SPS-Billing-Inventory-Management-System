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
    public partial class INVENTORY : Form
    {
        DataTable dt;
        MainForm mf;

        public INVENTORY(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();
            fillData();
            groupBox1.Visible = false;
            ApplyModernStyle();

        }


        //FUNCTION TO SHOW ALL PRODUCTS
        private void fillData()
        {
            INVENTORY_CLS invt = new INVENTORY_CLS();
            dataGridView1.DataSource = invt.fillGrid();
            //dataGridView1.Columns["price"].Visible = false;


        }


        //BUTTON CLICK EVENT TO UPDATE THE GST SLAB OF A HSN
        //private void btnAddProduct_Click(object sender, EventArgs e)
        //{
        //    clsProduct prod = new clsProduct();
        //    //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["product_id"].Value);
        //    if (groupBox1.Visible == false)
        //    {
        //        dt = prod.getHSN();
        //        cmbHSN.DataSource = dt;
        //        cmbHSN.DisplayMember = "hscin_id";
        //        cmbHSN.ValueMember = "gst_rate";                
        //        groupBox1.Visible = true;
        //    }
        //    else
        //    {                
        //        int hsn;
        //        int.TryParse(cmbHSN.Text, out hsn);
        //        int new_rate = (int)numericUpDownnNewRate.Value;                
        //        try
        //        {
        //            var conf = MessageBox.Show("CONFIRM TO UPDATE THE GST SLAB OF THE SELECTED HSN : " + hsn.ToString(),
        //            "UPDATE GST SLAB",
        //            MessageBoxButtons.YesNo);
                    
        //            if (conf == DialogResult.Yes)
        //            {                        
        //                prod.updateGstSlab(hsn, new_rate);
        //                MessageBox.Show("UPDATED SUCCESSFULLY");
        //            }                                       
                  
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("FAILED TO UPDATE");
        //        }

        //        groupBox1.Visible = false;
                
                
        //    }
        //    //mf.childTriggerLoadNewForm(new AddProduct());                        
        //}

        /// <summary>
        /// BUTTON CLICK EVENT TO LOAD MANAGE STOCK FORM IN THE MAINFORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManageStock_Click(object sender, EventArgs e)
        {
            ADD_STOCK mgstk = new ADD_STOCK(mf);
            mf.childTriggerLoadNewForm(mgstk);
        }

        //BUTTON CLICK EVENT TO REMOVE A PRODUCT FROM THE INVENTORY
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("SELECT A ROW FIRST");
            }
            else
            {
                var conf = MessageBox.Show("HAVE YOU CHECKED THE STOCK OF THE PRODUCT YOU WANT TO DELETE",
                    "REMOVE PRODUCT FROM INVENTORY",
                    MessageBoxButtons.YesNo);

                if (conf == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["product_id"].Value);
                    try
                    {
                        int res = clsProduct.removeProduct(id);
                        if (res == 1)
                        {
                            MessageBox.Show("YOU DELETED A PRODUCT");
                        }
                        else
                        {
                            MessageBox.Show("SOME ERROR OCCURED");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                
            }
        }

        private void cmbHSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrnetSlabDisp.Text = cmbHSN.SelectedValue.ToString();
        }
        //BUTTON TO LOAD FORM TO ADD PRODUCTS IN INVENTORY
        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            mf.childTriggerLoadNewForm(new AddProduct(mf));
        }

        private void btnEditGstSlab(object sender, EventArgs e)
        {
            clsProduct prod = new clsProduct();
            //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["product_id"].Value);
            if (groupBox1.Visible == false)
            {
                dt = prod.getHSN();
                cmbHSN.DataSource = dt;
                cmbHSN.DisplayMember = "hscin_id";
                cmbHSN.ValueMember = "gst_rate";
                groupBox1.Visible = true;
            }
            else
            {
                int hsn;
                int.TryParse(cmbHSN.Text, out hsn);
                int new_rate = (int)numericUpDownnNewRate.Value;
                try
                {
                    var conf = MessageBox.Show("CONFIRM TO UPDATE THE GST SLAB OF THE SELECTED HSN : " + hsn.ToString(),
                    "UPDATE GST SLAB",
                    MessageBoxButtons.YesNo);

                    if (conf == DialogResult.Yes)
                    {
                        prod.updateGstSlab(hsn, new_rate);
                        MessageBox.Show("UPDATED SUCCESSFULLY");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("FAILED TO UPDATE");
                }

                groupBox1.Visible = false;


            }

        }

        //FUNCTIONS TO ADORN FORM BUTTONS
        private void ApplyModernStyle()
        {
            StyleButton(btnUpdateGst, Color.FromArgb(52, 152, 219));
            StyleButton(btnAddProduct, Color.FromArgb(46, 204, 113));
            StyleButton(btnManageStock, Color.FromArgb(155, 89, 182));
            StyleButton(btnRemoveProduct, Color.FromArgb(231, 76, 60));
        }

        //FUNCTION TO ADORN FORM BUTTONS
        private void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

    }
}
