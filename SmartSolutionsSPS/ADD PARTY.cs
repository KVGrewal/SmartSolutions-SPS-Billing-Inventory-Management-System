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
    public partial class ADD_PARTY : Form        
    {
        MainForm mf;
        public ADD_PARTY(MainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            CenterPanel();
            this.Resize += ADD_PARTY_Resize;
        }

        //FUNCTION TO CENTRALIZE THE PANEL
        private void CenterPanel()
        {
            // Center panelMain horizontally and vertically
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
        }

        //FUNCTION TO KEEP THE PANEL CENTERED ON RESIZING THE WINDOW
        private void ADD_PARTY_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text.Trim()) || string.IsNullOrWhiteSpace(txtCustomerAddress.Text.Trim()))
            {
                MessageBox.Show("FILL VALUES IN ALL FIELDS");
            }

            else
            {
                clsAddCustomer addCustomer = new clsAddCustomer();
                addCustomer.name = txtCustomerName.Text.Trim();
                addCustomer.address = txtCustomerAddress.Text.Trim();
                int res;
                try
                {
                    res = addCustomer.addCustomer();
                    if (res > 0)
                    {
                        MessageBox.Show("Customer Added Successfully");                        
                        //mf.childTriggerLoadNewForm(new ADD_PARTY(mf));
                    }
                    txtCustomerName.Text = string.Empty;
                    txtCustomerAddress.Text = string.Empty;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show(txtCustomerName.Text.Trim() + " from " + txtCustomerAddress.Text.Trim() + " already exits in database.");
                    }
                }
            }
            
        }
    }
}
