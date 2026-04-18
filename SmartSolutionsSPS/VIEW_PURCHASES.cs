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
    public partial class VIEW_PURCHASES : Form
    {
        public VIEW_PURCHASES()
        {
            InitializeComponent();
            fillGrid();
            addButtons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Columns.Add(btnDetails);

            //ADDING BUTTON IN GRIDVIEW TO ADD PAYMENTS
            DataGridViewButtonColumn btnAddPayment = new DataGridViewButtonColumn();
            btnAddPayment.Name = "addPayment";
            btnAddPayment.HeaderText = "Action";
            btnAddPayment.Text = "ADD PAYMENT";
            btnAddPayment.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnAddPayment);

            //ADDING BUTTON IN GRIDVIEW TO GET PAYMENT HISTORY
            DataGridViewButtonColumn btnPaymentDetails = new DataGridViewButtonColumn();
            btnPaymentDetails.Name = "paymentHistory";
            btnPaymentDetails.HeaderText = "Action";
            btnPaymentDetails.Text = "PAYMENT HISTORY";
            btnPaymentDetails.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnPaymentDetails);
        }

        //FUNCTION TO SHOW ALL PURCHASES
        private void fillGrid()
        {
            try
            {
                dataGridView1.DataSource = clsPurchases.fillGrid();
            }
            catch (Exception e)
            { 
            }
        }


        //CELL CLICK EVENT TO GET DETAILS, VIEW PAYMENT HISTORY ADN ADD PAYMENT TO A PURCHASE,
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //CHUNK TO GET THE DETAILS OF A SPECIFIC TRANSACTION
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Details" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding SALE
                object value = dataGridView1.Rows[e.RowIndex].Cells["bill_no"].Value;
                string billNo = Convert.ToString(value);
                if ((value != null))
                {
                    try
                    {
                        clsPurchases purchase = new clsPurchases();
                        dataGridViewDetails.DataSource = purchase.showPurchaseDetails(billNo);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            //CHUNK TO ADD PAYMENT CORRESPONDING TO A TRANSACTION
            if (dataGridView1.Columns[e.ColumnIndex].Name == "addPayment" && e.RowIndex >= 0)
            {
                pnlAddPayment.Visible = true;
                pnlAddPayment.BringToFront();
            }

            //CHUNK TO VIEW PAYMENT HISTORY CORRESPONDING OF A TRANSACTION
            if (dataGridView1.Columns[e.ColumnIndex].Name == "paymentHistory" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding SALE
                object value = dataGridView1.Rows[e.RowIndex].Cells["bill_no"].Value;
                string bill_no = Convert.ToString(value);
                if ((value != null))
                {
                    try
                    {
                        clsPurchases purchase = new clsPurchases();
                        dataGridViewDetails.DataSource = purchase.showPayments(bill_no);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

        }


        //FUNCTION TO ADD PAYMENT TO A SPECIFIC PURCHASE
        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            string bill_no = Convert.ToString(dataGridView1.SelectedRows[0].Cells["bill_no"].Value);
            //int sales_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["sales_id"].Value);
            decimal amt_paid;
            decimal.TryParse(txtPaidAmount.Text.Trim(), out amt_paid);
            DateTime date = dateTimePicker.Value.Date;
            clsPurchases purchase = new clsPurchases();

            if (string.IsNullOrEmpty(txtPaidAmount.Text.Trim()))
            {
                MessageBox.Show("ENTER A VALUE FIRST");
            }
            else if (purchase.addPayment(bill_no, amt_paid, date) > 0)
            {

                pnlAddPayment.BackColor = Color.AliceBlue;
                btnConfirmUpdate.Text = "SALE UPDATED";
                btnConfirmUpdate.Enabled = false;
                btnCancelUpdate.Text = "BACK";
                fillGrid();
            }
            else
            {
                MessageBox.Show("FAILED TO UPDATE");
            }

        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlAddPayment.Visible = false;
            txtPaidAmount.Text = string.Empty;
            pnlAddPayment.BackColor = Color.White;
            btnConfirmUpdate.Text = "CONFIRM";
            btnConfirmUpdate.Enabled = true;
            btnCancelUpdate.Text = "CANCEL";
        }

        
    }
}
