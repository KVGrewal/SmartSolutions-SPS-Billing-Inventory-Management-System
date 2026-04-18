using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;   // For WinForms

//using Microsoft.Reporting.WebForms;   // For ASP.NET


namespace SmartSolutionsSPS
{
    public partial class VIEW_SALES : Form
    {
        public DataSet1 ds;
        private clsSales sale;
        DataTable dt;
        DataView dv;
        MainForm mf;

        public VIEW_SALES(MainForm _mf)
        {            
            InitializeComponent();
            string[] status = { "ALL", "ONLY FULLLY PAID", "ONLY PENDING PAYMENT" };
            comboBoxFilter.Items.AddRange(status);
            load_data();
            mf = _mf;
            addButtons();
        }

        private void load_data()
        {
            dataGridViewSales.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewSales.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewSales.EnableHeadersVisualStyles = false;
            dataGridViewSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dataGridViewSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewSales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewSales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //reportViewer1.Visible = false;

            try
            {
                sale = new clsSales();
                dt = sale.fillData(0);
                dv = new DataView(dt);
            }
            catch (Exception ex)
            { 
            }
            showSales();            
            //dataGridViewSales.Columns["customer_id"].Visible = false;
        }

        //FUNCTION TO LOAD ALL SALES
        private void showSales()
        {
            if (comboBoxFilter.Text.Trim() == "ALL")
            {
                dv.RowFilter = string.Empty;
            }

            if (comboBoxFilter.Text.Trim() == "ONLY FULLLY PAID")
            {
                dv.RowFilter = "amount = paid_amt";
            }

            if (comboBoxFilter.Text.Trim() == "ONLY PENDING PAYMENT")
            {
                dv.RowFilter = "amount <> paid_amt";
            }

            dataGridViewSales.DataSource = dv;                   
        }

        //FUNCTION TO ADD BUTTONS IN THE GRIDVIEW
        private void addButtons()
        {
            //adding details button in the gridview
            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
            btnDetails.Name = "Details";
            btnDetails.HeaderText = "Action";
            btnDetails.Text = "Details";
            btnDetails.UseColumnTextForButtonValue = true;
            dataGridViewSales.Columns.Add(btnDetails);

            //ADDING BUTTON IN GRIDVIEW TO ADD PAYMENTS
            DataGridViewButtonColumn btnAddPayment = new DataGridViewButtonColumn();
            btnAddPayment.Name = "addPayment";
            btnAddPayment.HeaderText = "Action";
            btnAddPayment.Text = "ADD PAYMENT";
            btnAddPayment.UseColumnTextForButtonValue = true;
            dataGridViewSales.Columns.Add(btnAddPayment);

            //ADDING BUTTON IN GRIDVIEW TO GET PAYMENT HISTORY
            DataGridViewButtonColumn btnPaymentDetails = new DataGridViewButtonColumn();
            btnPaymentDetails.Name = "paymentHistory";
            btnPaymentDetails.HeaderText = "Action";
            btnPaymentDetails.Text = "PAYMENT HISTORY";
            btnPaymentDetails.UseColumnTextForButtonValue = true;
            dataGridViewSales.Columns.Add(btnPaymentDetails);

            //ADDING BUTTON IN GRIDVIEW TO PRINT SALE SPECIFIC REPORT
            DataGridViewButtonColumn btnPrintSale = new DataGridViewButtonColumn();
            btnPrintSale.Name = "printSale";
            btnPrintSale.HeaderText = "Action";
            btnPrintSale.Text = "PRINT SALE";
            btnPrintSale.UseColumnTextForButtonValue = true;
            dataGridViewSales.Columns.Add(btnPrintSale);
        }

        //CELL CLICK EVENT TO GET DETAILS, VIEW PAYMENT HISTORY ADN ADD PAYMENT TO A TRANSACTION,
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CHUNK TO GET THE DETAILS OF A SPECIFIC TRANSACTION
            if (dataGridViewSales.Columns[e.ColumnIndex].Name == "Details" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding SALE
                object value = dataGridViewSales.Rows[e.RowIndex].Cells["sales_id"].Value;
                int s_id;
                if ((value != null) && int.TryParse(value.ToString(), out s_id))
                {
                    try
                    {
                        sale = new clsSales();
                        dataGridViewDetails.DataSource =  sale.fillData(s_id);
                    }
                    catch(Exception ex)
                    {
                    }
                }
            }


            //CHUNK TO VIEW PAYMENT HISTORY CORRESPONDING OF A TRANSACTION
            if (dataGridViewSales.Columns[e.ColumnIndex].Name == "paymentHistory" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding SALE
                object value = dataGridViewSales.Rows[e.RowIndex].Cells["sales_id"].Value;
                int s_id;
                if ((value != null) && int.TryParse(value.ToString(), out s_id))
                {
                    try
                    {
                        sale = new clsSales();
                        dataGridViewDetails.DataSource = sale.showPayments(s_id);
                    }
                    catch (Exception ex)
                    { 
                    }
                }
            }

            //CHUNK TO ADD PAYMENT CORRESPONDING TO A TRANSACTION
            if (dataGridViewSales.Columns[e.ColumnIndex].Name == "addPayment" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding SALE
                //object value = dataGridView1.Rows[e.RowIndex].Cells["sales_id"].Value;
                //int s_id;
                //if ((value != null) && int.TryParse(value.ToString(), out s_id))
                //{
                //    clsSales.showPayments(dataGridViewDetails, s_id);
                //}

                if (dataGridViewSales.SelectedRows.Count != 1)
                {
                    MessageBox.Show("SELECT A SINGLE ROW TO UPDATE");
                }
                else if (dataGridViewSales.SelectedRows.Count == 1)
                {
                    int c_id;
                    int.TryParse(dataGridViewSales.SelectedRows[0].Cells["customer_id"].Value.ToString(), out c_id);                    

                    if (c_id == 0)
                    {
                        MessageBox.Show("THE CUSTOMER IS NOT SAVED BY YOU");
                    }
                    else
                    {
                        pnlUpdateSale.Visible = true;
                        pnlUpdateSale.BringToFront();
                    }
                    
                }
            }

        }        

        //FUNCTION TO ADD PAYMENT TO A SPECIFIC SALE
        private void btnConfirmSaleUpdate_Click(object sender, EventArgs e)
        {
            int customer_id = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["customer_id"].Value);
            int sales_id = Convert.ToInt32(dataGridViewSales.SelectedRows[0].Cells["sales_id"].Value);
            decimal amt_paid;
            decimal.TryParse(txtPanelPaid.Text.Trim(), out amt_paid);
            DateTime date = dateAddPayment.Value.Date;
            sale = new clsSales();

            if(string.IsNullOrEmpty(txtPanelPaid.Text.Trim()))
            {
                MessageBox.Show("ENTER A VALUE FIRST");
            }
            else if (sale.addPayment(customer_id, sales_id, amt_paid, date) > 0)
            {
                pnlUpdateSale.BackColor = Color.AliceBlue;
                btnConfirmSaleUpdate.Text = "SALE UPDATED";
                btnConfirmSaleUpdate.Enabled = false;
                btnCancelSaleUpdate.Text = "BACK";
                sale.fillData(0);
            }
            else
            {
                MessageBox.Show("FAILED TO UPDATE");
            }
        }


        private void btnCancelSaleUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateSale.Visible = false;
            txtPanelPaid.Text = string.Empty;
            pnlUpdateSale.BackColor = Color.White;
            btnConfirmSaleUpdate.Text = "CONFIRM";
            btnConfirmSaleUpdate.Enabled = true;
            btnCancelSaleUpdate.Text = "CANCEL";
            load_data();
        }

        //COMBOBOX INDEX CHANGE EVENT TO FILTER DATA
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSales();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {            

            // Get the id of the corresponding SALE
            if(dataGridViewSales.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a single row.");
                return;
            }
            object sales = dataGridViewSales.SelectedRows[0].Cells["sales_id"].Value;
            object billSta = dataGridViewSales.SelectedRows[0].Cells["billed_status"].Value;
            int s_id, bill_stat;
            int.TryParse(billSta.ToString(), out bill_stat);
            if ((sales != null) && int.TryParse(sales.ToString(), out s_id))
            {
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
                        if (bill_stat == 0)
                        {
                            newRow.BillType = "Original";
                        }
                        else
                        {
                            newRow.BillType = "Duplicate";
                        }

                        // Add the row to the typed DataTable
                        ds.DataTable1.AddDataTable1Row(newRow);
                    }
                    

                    dataGridViewDetails.DataSource = ds.DataTable1;                    
                    mf.childTriggerLoadNewForm(ds);                                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()+"####view sales");
                }
            }
        }

        private void VIEW_SALES_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
        //BUTTON CLICK EVENT FOR PRINTING SALES REPORT
        //CALLED BY FORM
        private void btnPrintSalesReport_Click(object sender, EventArgs e)
        {
            mf.childTriggerLoadNewForm(new SalesReport());
        }

    }
}