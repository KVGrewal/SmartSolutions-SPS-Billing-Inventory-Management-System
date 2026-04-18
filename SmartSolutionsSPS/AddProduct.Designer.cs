namespace SmartSolutionsSPS
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHSCIN = new System.Windows.Forms.Label();
            this.txtHSCIN = new System.Windows.Forms.TextBox();
            this.lblNAME = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.lblBRAND = new System.Windows.Forms.Label();
            this.txtBRAND = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.lblInitialStock = new System.Windows.Forms.Label();
            this.txtInitialStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHSCIN
            // 
            this.lblHSCIN.AutoSize = true;
            this.lblHSCIN.Location = new System.Drawing.Point(161, 25);
            this.lblHSCIN.Name = "lblHSCIN";
            this.lblHSCIN.Size = new System.Drawing.Size(73, 13);
            this.lblHSCIN.TabIndex = 0;
            this.lblHSCIN.Text = "HSCIN CODE";
            // 
            // txtHSCIN
            // 
            this.txtHSCIN.Location = new System.Drawing.Point(306, 17);
            this.txtHSCIN.Name = "txtHSCIN";
            this.txtHSCIN.Size = new System.Drawing.Size(100, 20);
            this.txtHSCIN.TabIndex = 0;
            // 
            // lblNAME
            // 
            this.lblNAME.AutoSize = true;
            this.lblNAME.Location = new System.Drawing.Point(484, 17);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(94, 13);
            this.lblNAME.TabIndex = 2;
            this.lblNAME.Text = "PRODUCT NAME";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(680, 13);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(100, 20);
            this.txtNAME.TabIndex = 1;
            // 
            // lblBRAND
            // 
            this.lblBRAND.AutoSize = true;
            this.lblBRAND.Location = new System.Drawing.Point(164, 75);
            this.lblBRAND.Name = "lblBRAND";
            this.lblBRAND.Size = new System.Drawing.Size(45, 13);
            this.lblBRAND.TabIndex = 4;
            this.lblBRAND.Text = "BRAND";
            // 
            // txtBRAND
            // 
            this.txtBRAND.Location = new System.Drawing.Point(306, 67);
            this.txtBRAND.Name = "txtBRAND";
            this.txtBRAND.Size = new System.Drawing.Size(100, 20);
            this.txtBRAND.TabIndex = 2;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(167, 130);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(59, 13);
            this.lblGST.TabIndex = 8;
            this.lblGST.Text = "GST SLAB";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(306, 122);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(100, 20);
            this.txtGST.TabIndex = 3;
            // 
            // lblInitialStock
            // 
            this.lblInitialStock.AutoSize = true;
            this.lblInitialStock.Location = new System.Drawing.Point(487, 122);
            this.lblInitialStock.Name = "lblInitialStock";
            this.lblInitialStock.Size = new System.Drawing.Size(109, 13);
            this.lblInitialStock.TabIndex = 11;
            this.lblInitialStock.Text = "ADD INITIAL STOCK";
            // 
            // txtInitialStock
            // 
            this.txtInitialStock.Location = new System.Drawing.Point(680, 114);
            this.txtInitialStock.Name = "txtInitialStock";
            this.txtInitialStock.Size = new System.Drawing.Size(100, 20);
            this.txtInitialStock.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(680, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInitialStock);
            this.Controls.Add(this.lblInitialStock);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.txtBRAND);
            this.Controls.Add(this.lblBRAND);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.lblNAME);
            this.Controls.Add(this.txtHSCIN);
            this.Controls.Add(this.lblHSCIN);
            this.Name = "AddProduct";
            this.Text = "INVENTORY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHSCIN;
        private System.Windows.Forms.TextBox txtHSCIN;
        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Label lblBRAND;
        private System.Windows.Forms.TextBox txtBRAND;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label lblInitialStock;
        private System.Windows.Forms.TextBox txtInitialStock;
        private System.Windows.Forms.Button btnAdd;
    }
}