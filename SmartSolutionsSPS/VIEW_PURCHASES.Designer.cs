namespace SmartSolutionsSPS
{
    partial class VIEW_PURCHASES
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle defaultStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.pnlAddPayment = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.pnlAddPayment.SuspendLayout();
            this.SuspendLayout();

            // ================= FORM =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 561);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "PURCHASE DASHBOARD";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ================= MAIN GRID =================
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(89, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 200);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

            defaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            defaultStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.DefaultCellStyle = defaultStyle;

            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 248, 255);

            this.dataGridView1.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            // ================= DETAILS GRID =================
            this.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetails.Location = new System.Drawing.Point(89, 330);
            this.dataGridViewDetails.Size = new System.Drawing.Size(832, 160);
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewDetails.RowHeadersVisible = false;
            this.dataGridViewDetails.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewDetails.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridViewDetails.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 248, 255);

            // ================= PAYMENT PANEL =================
            this.pnlAddPayment.BackColor = System.Drawing.Color.White;
            this.pnlAddPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddPayment.Location = new System.Drawing.Point(359, 140);
            this.pnlAddPayment.Size = new System.Drawing.Size(342, 250);
            this.pnlAddPayment.Visible = false;

            this.lblPaidAmount.Text = "ENTER PAID AMOUNT";
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaidAmount.Location = new System.Drawing.Point(70, 25);
            this.lblPaidAmount.AutoSize = true;

            this.txtPaidAmount.Location = new System.Drawing.Point(95, 70);
            this.txtPaidAmount.Size = new System.Drawing.Size(150, 23);

            this.dateTimePicker.Location = new System.Drawing.Point(95, 115);
            this.dateTimePicker.Size = new System.Drawing.Size(150, 23);

            // Confirm Button
            this.btnConfirmUpdate.Text = "CONFIRM";
            this.btnConfirmUpdate.Location = new System.Drawing.Point(40, 180);
            this.btnConfirmUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdate.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdate.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnConfirmUpdate.ForeColor = System.Drawing.Color.White;
            this.btnConfirmUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmUpdate.Click +=
                new System.EventHandler(this.btnConfirmUpdate_Click);

            // Cancel Button
            this.btnCancelUpdate.Text = "CANCEL";
            this.btnCancelUpdate.Location = new System.Drawing.Point(190, 180);
            this.btnCancelUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpdate.FlatAppearance.BorderSize = 0;
            this.btnCancelUpdate.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCancelUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelUpdate.Click +=
                new System.EventHandler(this.btnCancelUpdate_Click);

            this.pnlAddPayment.Controls.Add(this.lblPaidAmount);
            this.pnlAddPayment.Controls.Add(this.txtPaidAmount);
            this.pnlAddPayment.Controls.Add(this.dateTimePicker);
            this.pnlAddPayment.Controls.Add(this.btnConfirmUpdate);
            this.pnlAddPayment.Controls.Add(this.btnCancelUpdate);

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.pnlAddPayment);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.pnlAddPayment.ResumeLayout(false);
            this.pnlAddPayment.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Panel pnlAddPayment;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Button btnCancelUpdate;
    }
}