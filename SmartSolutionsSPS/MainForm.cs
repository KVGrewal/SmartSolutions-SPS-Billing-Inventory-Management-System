using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private bool isLogin = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Dashboard(this));
            //ShowMessage("Home clicked");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ADD_PARTY(this));
        }

        private void btnParties_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new VIEW_PARTIES());
        }        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void ShowMessage(string message)
        {
            mainContent.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Font = new Font("Segoe UI", 16);
            lbl.AutoSize = true;
            lbl.Location = new Point(30, 30);

            mainContent.Controls.Add(lbl);
        }        

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new VIEW_SALES(this));
        }    

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new INVENTORY(this));
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainContent.Controls.Clear();
            mainContent.Controls.Add(childForm);
            mainContent.Tag = childForm;
            childForm.BackColor = Color.LightBlue;
            childForm.BringToFront();
            childForm.Show();
        }

       
        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Add_Purchases(this));
        }

        private void btnViewPurchase_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new VIEW_PURCHASES());
        }
        
        #region
        /// <summary>
        /// button invocation from child forms
        /// </summary>

        public void childTriggerAddParty()
        {
            btnParty.PerformClick();
        }

        public void childTriggerTransaction()
        {
            btnMakeTransaction.PerformClick();
        }        

        public void childTriggerViewProducts()
        {
            btnAddPurchase.PerformClick();
        }
        /// <summary>
        /// THIS FUNCTION LOADS THE FORM IN THE MAINSPACE VIA EXISTING FORMS
        /// CALLING FUNCTIONS
        /// FUNCTION : BUTTON CLICK EVENT - MANAGE STOCK, CLASS : INVENTORY.cs FORM
        /// FUNCTION : BUTTON CLICK EVENT - btnAddPurchase, CLASS : AddPurchases.cs - FORM
        /// </summary>
        /// <param name="form"></param>
        public void childTriggerLoadNewForm(Form form)
        {
            LoadFormIntoPanel(form);
        }
        #endregion

        /// <summary>
        /// THIS FUNCTION LOADS THE FORM IN THE MAINSPACE VIA EXISTING FORMS
        /// CALLING FUNCTIONS
        /// FUNCTION : BUTTON CLICK EVENT - MANAGE STOCK, CLASS : INVENTORY.cs FORM
        /// FUNCTION : BUTTON CLICK EVENT - btnAddPurchase, CLASS : AddPurchases.cs - FORM
        /// </summary>
        /// <param name="form"></param>
        public void childTriggerLoadNewForm(DataSet1 ds)
        {
            LoadFormIntoPanel(new Bill(ds));
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //frmSaleReport objSaleRepot = new frmSaleReport();
            //objSaleRepot.Show();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Statistics());
        }

    }
}
