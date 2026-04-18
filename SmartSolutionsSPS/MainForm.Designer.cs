//using System.Windows.Forms;
namespace SmartSolutionsSPS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnParty;
        private System.Windows.Forms.Button btnParties;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Button btnViewPurchase;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logoPictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.navBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnParty = new System.Windows.Forms.Button();
            this.btnParties = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnViewPurchase = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainContent = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.navBar.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.navBar.Controls.Add(this.lblTitle);
            this.navBar.Controls.Add(this.btnMakeTransaction);
            this.navBar.Controls.Add(this.btnParty);
            this.navBar.Controls.Add(this.btnParties);
            this.navBar.Controls.Add(this.btnViewProducts);
            this.navBar.Controls.Add(this.btnViewTransactions);
            this.navBar.Controls.Add(this.btnAddPurchase);
            this.navBar.Controls.Add(this.btnViewPurchase);
            this.navBar.Controls.Add(this.btnLogout);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(200, 600);
            this.navBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeTransaction.ForeColor = System.Drawing.Color.White;
            this.btnMakeTransaction.Location = new System.Drawing.Point(10, 70);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(180, 40);
            this.btnMakeTransaction.TabIndex = 1;
            this.btnMakeTransaction.Text = "MAKE TRANSACTION";
            this.btnMakeTransaction.UseVisualStyleBackColor = false;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnParty
            // 
            this.btnParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParty.ForeColor = System.Drawing.Color.White;
            this.btnParty.Location = new System.Drawing.Point(10, 120);
            this.btnParty.Name = "btnParty";
            this.btnParty.Size = new System.Drawing.Size(180, 40);
            this.btnParty.TabIndex = 2;
            this.btnParty.Text = "ADD CUSTOMER";
            this.btnParty.UseVisualStyleBackColor = false;
            this.btnParty.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnParties
            // 
            this.btnParties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParties.ForeColor = System.Drawing.Color.White;
            this.btnParties.Location = new System.Drawing.Point(10, 170);
            this.btnParties.Name = "btnParties";
            this.btnParties.Size = new System.Drawing.Size(180, 40);
            this.btnParties.TabIndex = 3;
            this.btnParties.Text = "VIEW PARTIES";
            this.btnParties.UseVisualStyleBackColor = false;
            this.btnParties.Click += new System.EventHandler(this.btnParties_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProducts.ForeColor = System.Drawing.Color.White;
            this.btnViewProducts.Location = new System.Drawing.Point(10, 220);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(180, 40);
            this.btnViewProducts.TabIndex = 4;
            this.btnViewProducts.Text = "VIEW PRODUCTS";
            this.btnViewProducts.UseVisualStyleBackColor = false;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTransactions.ForeColor = System.Drawing.Color.White;
            this.btnViewTransactions.Location = new System.Drawing.Point(10, 270);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(180, 40);
            this.btnViewTransactions.TabIndex = 4;
            this.btnViewTransactions.Text = "VIEW TRANSACTIONS";
            this.btnViewTransactions.UseVisualStyleBackColor = false;
            this.btnViewTransactions.Click += new System.EventHandler(this.btnViewTransactions_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.Location = new System.Drawing.Point(10, 320);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(180, 40);
            this.btnAddPurchase.TabIndex = 4;
            this.btnAddPurchase.Text = "ADD PURCHASE";
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // btnViewPurchase
            // 
            this.btnViewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPurchase.ForeColor = System.Drawing.Color.White;
            this.btnViewPurchase.Location = new System.Drawing.Point(10, 370);
            this.btnViewPurchase.Name = "btnViewPurchase";
            this.btnViewPurchase.Size = new System.Drawing.Size(180, 40);
            this.btnViewPurchase.TabIndex = 4;
            this.btnViewPurchase.Text = "VIEW PURCHASE";
            this.btnViewPurchase.UseVisualStyleBackColor = false;
            this.btnViewPurchase.Click += new System.EventHandler(this.btnViewPurchase_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 420);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 66);
            this.topPanel.TabIndex = 1;
            // 
            // mainContent
            // 
            this.mainContent.BackgroundImage = global::SmartSolutionsSPS.Properties.Resources.FormImage;
            this.mainContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(200, 66);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(800, 534);
            this.mainContent.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(10, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(140, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.navBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
