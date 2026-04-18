using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{        

    public partial class VIEW_PARTIES : Form
    {
        private DataTable dt;
        private clsPARTIES party;

        public VIEW_PARTIES()
        {
            InitializeComponent();
            fillData();
            addButtons();
            txtSearch.ForeColor = Color.Gray;                                     
        }
        

        //FUNCTIONS TO SHOW ALL CUSTOMER
        private void fillData()
        {
            party = new clsPARTIES();
            dt = clsPARTIES.showParties();
            dataGridViewShowParties.DataSource = dt;
        }

        //FUNCTION TO ADD BUTTONS IN THE GRIDVIEW
        private void addButtons()
        {
            //adding delete button in the gridview
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "Action";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewShowParties.Columns.Add(btnDelete);

            //adding update button in the gridview
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "Update";
            btnUpdate.HeaderText = "Action";
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            dataGridViewShowParties.Columns.Add(btnUpdate);
        }


        //CELL CONTENT CLICK EVENT OF GRID VIEW FOR DELETING AND UPDATING CUSTOMER
        private void dataGridViewShowParties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            

            //chunk to remove a customer
            if (dataGridViewShowParties.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                // Get the id of the corresponding customer
                object value = dataGridViewShowParties.Rows[e.RowIndex].Cells["customer_id"].Value;
                int c_id;
                var conf = MessageBox.Show("DO YOU REALLY WANT TO DELETE THE SELECTED CUSTOMER",
                    "DELETE CUSTOMER",
                    MessageBoxButtons.YesNo);
                if ((value != null) && int.TryParse(value.ToString(), out c_id) && conf == DialogResult.Yes)
                {
                    try
                    {
                        int res = clsPARTIES.removeCustomer(c_id);

                        string show = res > 0 ? "YOU DELETED A CUSTOMER" : "SOME ERROR OCCURED";

                        MessageBox.Show(show);
                        dataGridViewShowParties.DataSource = clsPARTIES.showParties(); // Automatically removes the row from the grid                    
                    }
                    catch (Exception ex)
                    { 
                    }
                }
            }

            //chunk to update a customer
            if (dataGridViewShowParties.Columns[e.ColumnIndex].Name == "Update" && e.RowIndex >= 0)
            {
                object value = dataGridViewShowParties.Rows[e.RowIndex].Cells["customer_id"].Value;
                string name = dataGridViewShowParties.Rows[e.RowIndex].Cells["customer_name"].Value.ToString();
                string address = dataGridViewShowParties.Rows[e.RowIndex].Cells["customer_address"].Value.ToString();
                int id;
                if((value != null) && int.TryParse(value.ToString(), out id))
                {
                    try
                    {
                        int res = clsPARTIES.updateCustomer(id, name, address);
                        if (res > 0)
                        {
                            MessageBox.Show("Customer Updated Successfully");
                            clsPARTIES.showParties();
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            clsPARTIES.showParties();
                            MessageBox.Show(name + " FROM " + address + " ALREADY EXISTS IN DATABASE.");                            
                        }
                    }
                }
            }

            dataGridViewShowParties.DataSource = dt;

        }


        private void dataGridViewShowParties_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewShowParties.IsCurrentCellDirty)
            {
                dataGridViewShowParties.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
       

        //FUNCTION TO SEARCH FROM MULTIPLE CUSTOMERS
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                // Agar textbox empty hai, puri table dikhao
                dataGridViewShowParties.DataSource = dt;
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
                dataGridViewShowParties.DataSource = dv;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
