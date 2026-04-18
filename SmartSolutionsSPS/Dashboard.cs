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
    public partial class Dashboard : Form
    {
        private DataTable dt;
        clsSales sale;
        MainForm _mf;
        clsDashboard ds;
        static DataTable prods = new DataTable();
        BindingList<clsOrder> list = new BindingList<clsOrder>();
        int sales_id;


        public Dashboard(MainForm mf)
        {
            InitializeComponent();
            _mf = mf;
            load_data();
            showProducts();
            cmbC_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbC_name.AutoCompleteSource = AutoCompleteSource.ListItems;
                       
            dataGridViewSelectedProducts.DataSource = list;            
            dataGridViewSelectedProducts.Columns["prod_id"].Visible = false;
            dataGridViewSelectedProducts.Columns["hsn"].Visible = false;
            dataGridViewSelectedProducts.Columns["stocks"].Visible = false;

            //CHANGING THE NAME OF COLUMN HEADERS          
            dataGridViewSelectedProducts.Columns["tax"].HeaderText = "Tax (₹)";
            dataGridViewSelectedProducts.Columns["gst"].HeaderText = "GST %";
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "Action";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewSelectedProducts.Columns.Add(btnDelete);
            dataGridViewSelectedProducts.CellContentClick += dataGridViewSelectedProducts_CellContentClick;            

            //METHOD FOR IMPROVING UI
            ApplyModernUI();
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;                
            }
            groupBox2.Visible = true;
            dateTimePicker1.Value = DateTime.Today;
            
        }        

        //FUNCTION TO SHOW THE AMOUNT TO BE COLLECTED                       
       
        //FUNCTION TO SHOW DATA ON THE DASHBOARD
        public void load_data()
        {            

            string[] status = {"Paid", "Not Paid", "Partially Paid"};                                          
            cmbPaymentStatus.Items.AddRange(status);
            fillCustomer();            
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;            
        }        

        //FUNCTION TO GET THE NAMES OF THE CUSTOMERS
        private void fillCustomer()
        {
            clsDashboard dash = new clsDashboard();
            DataTable dt = dash.fillCustomer();
            cmbC_name.DataSource = dt;
            cmbC_name.DisplayMember = "customer_name";
            cmbC_name.ValueMember = "customer_name";
            cmbC_name.SelectedIndex = -1;
        }                      

        //FUNCTIONS TO GET ADDRESS OF CUSTOMER BY NAME
        private void fillAddress()
        {
            clsDashboard dashAdd = new clsDashboard();
            dashAdd._CName = cmbC_name.Text.Trim();
            DataTable dt = dashAdd.getCustomer();
            cmbC_Add.DataSource = dt;
            cmbC_Add.DisplayMember = "customer_address";
            cmbC_Add.ValueMember = "customer_id";
        }      

        //FUNCTION TO SHOW PRODUCTS
        private void showProducts()
        {
            clsDashboard dashProducts = new clsDashboard();
            dt = dashProducts.showProducts();
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
            listBoxBrand.DataSource = dt;
            listBoxBrand.DisplayMember = "brand";
            listBoxBrand.ValueMember = "product_id";
        }


        //BUTTON CLICK EVENT TO LOAD FORM TO ADD NEW CUSTOMER
        private void btnProceed_Click(object sender, EventArgs e)
        {
            //_mf.childTriggerLoadNewForm(new ADD_PARTY(_mf));
            groupBox1.BringToFront();
            if (string.IsNullOrWhiteSpace(cmbC_name.Text.Trim()) || string.IsNullOrWhiteSpace(cmbC_Add.Text.Trim()))
            {
                MessageBox.Show("CHOSE A CUTOMER");
            }
            else
            {
                sale = new clsSales();

                sale.customer_name = cmbC_name.Text.Trim();
                sale.customer_address = cmbC_Add.Text.Trim();
                sale.date = dateTimePicker1.Value.Date;
                sale.setProp(list);



                panel1.Visible = true;
                panel1.BringToFront();

                if (cmbPaymentStatus.Text.Trim() == "Paid")
                {
                    sale.paid = sale.amount;
                }
                else if (cmbPaymentStatus.Text.Trim() == "Not Paid")
                {
                    sale.paid = 0;
                }
                else if (cmbPaymentStatus.Text.Trim() == "Partially Paid")
                {
                    sale.paid = Convert.ToDecimal(txtPartialPayment.Text.Trim());
                }



                lblPanelCustomerNameDisp.Text = sale.customer_name + ", " + sale.customer_address;
                lblPanelTaxableAmountDisp.Text = sale.taxable_amt.ToString();

                lblPanelTotalAmountDisp.Text = sale.amount.ToString();
                lblPanelPaidDisp.Text = sale.paid.ToString();
                lblPanelDateDisp.Text = sale.date.ToString();
                lblPanelCgstDisp.Text = sale.cgst.ToString();
                lblPanelSgstDisp.Text = sale.sgst.ToString();
            }
        }    


        //INDEX CHANGE EVENT OF PAYMENT STATUS COMBOBOX TO ENABLE PAYMENT STATUS TEXTBOX
        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentStatus.Text.Trim() == "Partially Paid")
            {
                txtPartialPayment.Enabled = true;
            }

            if (cmbPaymentStatus.Text.Trim() == "Paid")
            {
                txtPartialPayment.Enabled = false;
            }

            if (cmbPaymentStatus.Text.Trim() == "Not Paid")
            {
                txtPartialPayment.Enabled = false;
            }
        }


        //BUTTON CLICK EVENT TO SHOW THE SUMMARY OF A SALE
        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox2.Visible = false;
                //groupBox5.Visible = false;
                dataGridViewSelectedProducts.Visible = false;
                groupBox2.SendToBack();
                groupBox1.Visible = true;
                dateTimePicker1.Visible = true;
                groupBox1.BringToFront();
                btnSummary.Text = "RETURN";
            }
            else 
            {
                groupBox2.Visible = true;
                //groupBox5.Visible = true;
                dataGridViewSelectedProducts.Visible = true;
                groupBox2.BringToFront();
                groupBox1.Visible = false;
                dateTimePicker1.Visible = false;
                groupBox1.BringToFront();
                btnSummary.Text = "VIEW SUMMARY";
            }
            //groupBox1.BringToFront();
            //if (string.IsNullOrWhiteSpace(cmbC_name.Text.Trim()) || string.IsNullOrWhiteSpace(cmbC_Add.Text.Trim()))
            //{
            //    MessageBox.Show("CHOSE A CUTOMER");
            //}
            //else
            //{
            //    sale = new clsSales();

            //    sale.customer_name = cmbC_name.Text.Trim();
            //    sale.customer_address = cmbC_Add.Text.Trim();
            //    sale.date = dateTimePicker1.Value.Date;
            //    sale.setProp(list);



            //    panel1.Visible = true;
            //    panel1.BringToFront();

            //    if (cmbPaymentStatus.Text.Trim() == "Paid")
            //    {
            //        sale.paid = sale.amount;
            //    }
            //    else if (cmbPaymentStatus.Text.Trim() == "Not Paid")
            //    {
            //        sale.paid = 0;
            //    }
            //    else if (cmbPaymentStatus.Text.Trim() == "Partially Paid")
            //    {
            //        sale.paid = Convert.ToDecimal(txtPartialPayment.Text.Trim());
            //    }



            //    lblPanelCustomerNameDisp.Text = sale.customer_name + ", " + sale.customer_address;
            //    lblPanelTaxableAmountDisp.Text = sale.taxable_amt.ToString();

            //    lblPanelTotalAmountDisp.Text = sale.amount.ToString();
            //    lblPanelPaidDisp.Text = sale.paid.ToString();
            //    lblPanelDateDisp.Text = sale.date.ToString();
            //    lblPanelCgstDisp.Text = sale.cgst.ToString();
            //    lblPanelSgstDisp.Text = sale.sgst.ToString();
            //}

        }

        //BUTTON CLICK EVENT GO BACK
        private void btnGoBack_Click(object sender, EventArgs e)
        {            
            if (btnSave.Enabled == true)
            {
                panel1.Visible = false;
            }
            else 
            {
                _mf.childTriggerTransaction();
            }
            
        }

        //BUTTON CLICK EVENT TO SAVE A TRANSACTION
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                int a = Convert.ToInt32(cmbC_Add.SelectedValue);
                id = a > 0 ? a : 0;

                //string show = res > 0 ? "YOU DELETED A CUSTOMER" : "SOME ERROR OCCURED";

                //if (a > 0)
                //{
                //    id = a;
                //}
                //else
                //{
                //    id = 0;
                //}
                sales_id = sale.saveSale(list, a);
                //MessageBox.Show(w.ToString());
                if (sales_id > 0)
                {
                    MessageBox.Show("TRANSACTION SAVED SUCCESSFULLY");
                }
                panel1.BackColor = Color.AliceBlue;
                btnSave.Enabled = false;
                btnSave.Text = "TRANSACTION SAVED";
                btnGenerateBill.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        


        //CELL CLICK EVENT OF DATAGRIDVIEW TO DELETE AN OBJECT FROM THE LIST
        private void dataGridViewSelectedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)//K
        {
            // If the clicked cell is in the Delete button column
            if (dataGridViewSelectedProducts.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                // Get the corresponding object
                var Order = dataGridViewSelectedProducts.Rows[e.RowIndex].DataBoundItem as clsOrder;
                if (Order != null)
                {
                    decimal total = Convert.ToDecimal(lblOrderTotalAmt.Text);
                    total -= Order.Amount;
                    lblOrderTotalAmt.Text = total.ToString();
                    list.Remove(Order); // Automatically removes the row from the grid                    
                }
                if (list.Count == 0)
                {
                    dataGridViewSelectedProducts.Visible = false;
                    lblOrderTotalAmt.Visible = false;
                    groupBox5.Visible = false;
                }
            }
        }

        private void cmbC_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnAddCustomer.Visible = false;
            fillAddress();
        }


        //EVENT TO GET THE STOCKS OF SELECTED PRODUCT
        private void listBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsOrder ord = new clsOrder();
            int prod_id = (int)listBoxBrand.SelectedValue;            
            lblStocks.Text = "IN STOCK : " + ord.getStocks(prod_id).ToString();
        }

        #region
        //REGION FOR IMPROVING UI
        private void ApplyModernUI()
        {
            // ===== FORM BACKGROUND ONLY =====
            this.BackColor = Color.FromArgb(245, 247, 250);

            // ===== GROUPBOX COLOR ONLY (NO FONT CHANGE) =====
            StyleGroupBox(groupBox1);
            StyleGroupBox(groupBox2);          
            StyleGroupBox(groupBox5);

            // ===== BUTTON COLORS ONLY =====
            StyleButton(btnSave, Color.FromArgb(40, 167, 69));
            StyleButton(btnAddMoreItems, Color.FromArgb(0, 123, 255));
            StyleButton(btnSummary, Color.FromArgb(108, 117, 125));
            StyleButton(btnGoBack, Color.FromArgb(220, 53, 69));
            StyleButton(btnAddCustomer, Color.FromArgb(23, 162, 184));

            // ===== DATAGRID CLEAN STYLE =====
            dataGridViewSelectedProducts.BackgroundColor = Color.White;
            dataGridViewSelectedProducts.BorderStyle = BorderStyle.None;
            dataGridViewSelectedProducts.GridColor = Color.FromArgb(220, 220, 220);
            dataGridViewSelectedProducts.EnableHeadersVisualStyles = false;

            dataGridViewSelectedProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(52, 58, 64);
            dataGridViewSelectedProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridViewSelectedProducts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 249, 250);

            // ===== LABEL COLOR EMPHASIS ONLY =====
            lblOrderTotalAmt.ForeColor = Color.FromArgb(0, 123, 255);
            lblPanelTotalAmountDisp.ForeColor = Color.FromArgb(40, 167, 69);
            lblPanelPaidDisp.ForeColor = Color.FromArgb(40, 167, 69);
            
            // ===== FLAT INPUTS =====
            cmbC_name.FlatStyle = FlatStyle.Flat;
            cmbC_Add.FlatStyle = FlatStyle.Flat;
            cmbPaymentStatus.FlatStyle = FlatStyle.Flat;

            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPartialPayment.BorderStyle = BorderStyle.FixedSingle;

            // ===== SUMMARY PANEL CLEAN =====
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleButton(Button btn, Color bgColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bgColor;
            btn.ForeColor = Color.White;
        }

        private void StyleGroupBox(GroupBox box)
        {
            box.ForeColor = Color.FromArgb(45, 62, 80);
        }

        #endregion

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            int s_id = sales_id;
            try
            {
                sale = new clsSales();
                DataTable dt = sale.fillData(s_id);
                DataTable dt2 = sale.generateBill(s_id);
                DataSet1 ds = new DataSet1(); // make sure ds is instantiated
                //if (ds.DataTable1 == null)
                //{
                //    ds.DataTable1 = new DataSet1.DataTable1DataTable();
                //}

                foreach (DataRow row in dt2.Rows)
                {
                    // Create a new typed row
                    DataSet1.DataTable1Row newRow = ds.DataTable1.NewDataTable1Row();

                    // Map the values from your source DataTable
                    newRow.Name = row["customer_name"].ToString();
                    newRow.Address = row["customer_address"].ToString();
                    newRow.Particulars = row["PARTICULARS"].ToString();
                    newRow.Quantity = row["quantity"].ToString();
                    newRow.Price = row["price"].ToString();
                    newRow.Taxable_Amount = row["taxable_amt"].ToString();
                    newRow.GST = row["GST"].ToString();
                    newRow.Amount = row["amount"].ToString();
                    newRow.Total = row["total"].ToString();
                    newRow.SalesId = s_id.ToString();
                    newRow.BillType = "Original";
                    //if (bill_stat == 0)
                    //{
                    //    newRow.BillType = "Original";
                    //}
                    //else
                    //{
                    //    newRow.BillType = "Duplicate";
                    //}

                    // Add the row to the typed DataTable
                    ds.DataTable1.AddDataTable1Row(newRow);
                }


                //dataGridViewDetails.DataSource = ds.DataTable1;
                _mf.childTriggerLoadNewForm(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "####dashboard");
            }
        }

        //TEXT BOX TEXT CHANGE EVENT TO SEARCH PRODUCTS
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                // Agar textbox empty hai, puri table dikhao
                listBoxProducts.DataSource = dt;
            }
            else
            {
                // Filter rows where ANY column contains the search text
                DataView dv = new DataView(dt);
                string filterExpression = "";

                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType == typeof(string))
                    {
                        if (filterExpression.Length > 0) filterExpression += " OR ";
                        filterExpression += "[" + col.ColumnName + "] LIKE '%" + filterText + "%'";
                    }
                }

                dv.RowFilter = filterExpression;
                listBoxProducts.DataSource = dv;
            }

        }

        #region
        //Button click events

        //BUTTON CLICK EVENT TO ADD PRODUCTS TO SALE
        private void btnAddMoreItems_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedProducts.Visible == false)
            {
                dataGridViewSelectedProducts.Visible = true;
                btnSummary.Visible = true;
                dataGridViewSelectedProducts.BringToFront();
                lblOrderTotalAmt.Visible = true;
                groupBox5.Visible = true;
                lblOrderTotalAmt.Text = "0";
            }
            clsOrder order = new clsOrder();
            decimal price, total;
            decimal.TryParse(textBoxPrice.Text.Trim(), out price);
            decimal.TryParse(lblOrderTotalAmt.Text.Trim(), out total);
            order.Quantity = (int)numericUpDownQuantity.Value;
            order.prod_id = (int)listBoxBrand.SelectedValue;
            order.Price = price;
            order.setProperties(order.prod_id);
            total += order.Amount;
            lblOrderTotalAmt.Text = total.ToString();
            list.Add(order);
            dataGridViewSelectedProducts.Columns["bill_no"].Visible = false;
            showProducts();
            numericUpDownQuantity.Value = 0;
            textBoxPrice.Text = string.Empty;
        }        

        #endregion

    }
                              
    }
