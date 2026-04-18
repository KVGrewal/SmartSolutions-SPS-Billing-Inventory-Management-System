namespace SmartSolutionsSPS
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblToCollectAmt = new System.Windows.Forms.Label();
            this.lblToPayAmt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewShowData = new System.Windows.Forms.DataGridView();
            this.groupBoxTax = new System.Windows.Forms.GroupBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.buttonTotalSales = new System.Windows.Forms.Button();
            this.buttonTotalPurchases = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPaid = new System.Windows.Forms.RadioButton();
            this.radioButtonUnpaid = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).BeginInit();
            this.groupBoxTax.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblToCollectAmt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(68, 645);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 150);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TO COLLECT";
            // 
            // lblToCollectAmt
            // 
            this.lblToCollectAmt.AutoSize = true;
            this.lblToCollectAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCollectAmt.ForeColor = System.Drawing.Color.Green;
            this.lblToCollectAmt.Location = new System.Drawing.Point(48, 75);
            this.lblToCollectAmt.Name = "lblToCollectAmt";
            this.lblToCollectAmt.Size = new System.Drawing.Size(70, 26);
            this.lblToCollectAmt.TabIndex = 1;
            this.lblToCollectAmt.Text = "label1";
            // 
            // lblToPayAmt
            // 
            this.lblToPayAmt.AutoSize = true;
            this.lblToPayAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPayAmt.ForeColor = System.Drawing.Color.Red;
            this.lblToPayAmt.Location = new System.Drawing.Point(35, 75);
            this.lblToPayAmt.Name = "lblToPayAmt";
            this.lblToPayAmt.Size = new System.Drawing.Size(70, 26);
            this.lblToPayAmt.TabIndex = 1;
            this.lblToPayAmt.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToPayAmt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(483, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 150);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TO PAY";
            // 
            // dataGridViewShowData
            // 
            this.dataGridViewShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShowData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowData.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShowData.Location = new System.Drawing.Point(89, 75);
            this.dataGridViewShowData.Name = "dataGridViewShowData";
            this.dataGridViewShowData.Size = new System.Drawing.Size(10, 10);
            this.dataGridViewShowData.TabIndex = 29;
            this.dataGridViewShowData.Visible = false;
            // 
            // groupBoxTax
            // 
            this.groupBoxTax.Controls.Add(this.labelTax);
            this.groupBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTax.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxTax.Location = new System.Drawing.Point(885, 645);
            this.groupBoxTax.Name = "groupBoxTax";
            this.groupBoxTax.Size = new System.Drawing.Size(275, 150);
            this.groupBoxTax.TabIndex = 30;
            this.groupBoxTax.TabStop = false;
            this.groupBoxTax.Text = "TAX TO PAY";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(51, 75);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(64, 25);
            this.labelTax.TabIndex = 0;
            this.labelTax.Text = "label1";
            // 
            // buttonTotalSales
            // 
            this.buttonTotalSales.Location = new System.Drawing.Point(89, 187);
            this.buttonTotalSales.Name = "buttonTotalSales";
            this.buttonTotalSales.Size = new System.Drawing.Size(125, 25);
            this.buttonTotalSales.TabIndex = 31;
            this.buttonTotalSales.Text = "ALL SALES";
            this.buttonTotalSales.UseVisualStyleBackColor = true;
            this.buttonTotalSales.Click += new System.EventHandler(this.buttonAlllSales_Click);
            // 
            // buttonTotalPurchases
            // 
            this.buttonTotalPurchases.Location = new System.Drawing.Point(523, 186);
            this.buttonTotalPurchases.Name = "buttonTotalPurchases";
            this.buttonTotalPurchases.Size = new System.Drawing.Size(130, 25);
            this.buttonTotalPurchases.TabIndex = 32;
            this.buttonTotalPurchases.Text = "TOTAL PURCHASEES";
            this.buttonTotalPurchases.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(359, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonUnpaid);
            this.groupBox2.Controls.Add(this.radioButtonPaid);
            this.groupBox2.Controls.Add(this.radioButtonAll);
            this.groupBox2.Location = new System.Drawing.Point(89, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 183);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SALES";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(23, 45);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "ALL";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonPaid
            // 
            this.radioButtonPaid.AutoSize = true;
            this.radioButtonPaid.Location = new System.Drawing.Point(23, 84);
            this.radioButtonPaid.Name = "radioButtonPaid";
            this.radioButtonPaid.Size = new System.Drawing.Size(50, 17);
            this.radioButtonPaid.TabIndex = 1;
            this.radioButtonPaid.TabStop = true;
            this.radioButtonPaid.Text = "PAID";
            this.radioButtonPaid.UseVisualStyleBackColor = true;
            this.radioButtonPaid.CheckedChanged += new System.EventHandler(this.radioButtonPaid_CheckedChanged);
            // 
            // radioButtonUnpaid
            // 
            this.radioButtonUnpaid.AutoSize = true;
            this.radioButtonUnpaid.Location = new System.Drawing.Point(23, 125);
            this.radioButtonUnpaid.Name = "radioButtonUnpaid";
            this.radioButtonUnpaid.Size = new System.Drawing.Size(66, 17);
            this.radioButtonUnpaid.TabIndex = 2;
            this.radioButtonUnpaid.TabStop = true;
            this.radioButtonUnpaid.Text = "UNPAID";
            this.radioButtonUnpaid.UseVisualStyleBackColor = true;
            this.radioButtonUnpaid.CheckedChanged += new System.EventHandler(this.radioButtonUnpaid_CheckedChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonTotalPurchases);
            this.Controls.Add(this.buttonTotalSales);
            this.Controls.Add(this.groupBoxTax);
            this.Controls.Add(this.dataGridViewShowData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowData)).EndInit();
            this.groupBoxTax.ResumeLayout(false);
            this.groupBoxTax.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblToCollectAmt;
        private System.Windows.Forms.Label lblToPayAmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewShowData;
        private System.Windows.Forms.GroupBox groupBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Button buttonTotalSales;
        private System.Windows.Forms.Button buttonTotalPurchases;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonUnpaid;
        private System.Windows.Forms.RadioButton radioButtonPaid;
        private System.Windows.Forms.RadioButton radioButtonAll;
    }
}