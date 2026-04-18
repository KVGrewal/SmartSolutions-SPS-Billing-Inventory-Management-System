using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{
    class clsPurchases
    {
        public string bill { get; set; }//
        public string supplier { get; set; }//
        public decimal taxable_amt { get; set; }//
        public decimal tax { get; set; }//
        public decimal paid { get; set; }//
        public DateTime purchase_date { get; set; }//   
        public decimal total_amt { get; set; }        
        

        #region
        /// <summary>
        /// ADD A NEW PURCHASE IN THE DB
        /// CALLING CLASSESS
        /// Add_Purchases ON BUTTON CLICK EVENT
        /// </summary>
        
        #endregion



        /// <summary>
        /// ADD A NEW PURCHASE IN THE DB
        /// CALLING CLASSESS
        /// FORM VIEW_PURCHASES IN BUTTON fillGrid FUNCTION
        /// </summary>
        public static DataTable fillGrid()
        {
            DataSet ds = new DataSet();
            string[] tbl = {"tbl_purchase", "tbl_product"};
            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getAllPurchases, ds, tbl);
            return ds.Tables[0];

        }

        /// <summary>
        /// ADD A NEW PURCHASE IN THE DB
        /// CALLING CLASSESS
        /// Add_Purchases ON BUTTON CLICK EVENT
        /// </summary>
        public void addPurchase(System.ComponentModel.BindingList<clsOrder> list)
        {
            setProp(list);
            SqlParameter[] objParam = new SqlParameter[8];

            objParam[0] = new SqlParameter("@bill_no", SqlDbType.VarChar);
            objParam[0].Value = this.bill;

            objParam[1] = new SqlParameter("@purchase_date", SqlDbType.Date);
            objParam[1].Value = this.purchase_date;

            objParam[2] = new SqlParameter("@supplier", SqlDbType.VarChar);
            objParam[2].Value = this.supplier;

            objParam[3] = new SqlParameter("@taxable_amt", SqlDbType.Decimal);
            objParam[3].Value = this.taxable_amt;

            objParam[4] = new SqlParameter("@tax", SqlDbType.Decimal);
            objParam[4].Value = this.tax;

            objParam[5] = new SqlParameter("@total_amt", SqlDbType.Decimal);
            objParam[5].Value = this.total_amt;

            objParam[6] = new SqlParameter("@paid", SqlDbType.Decimal);
            objParam[6].Value = this.paid;

            objParam[7] = new SqlParameter("@list", SqlDbType.Structured);
            objParam[7].Value = listToTable(list);

            try
            {
                int res = SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.addPurchase, objParam);
                if (res > 0)
                {
                    MessageBox.Show("Purchase Added Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        //FUNCTION TO CONVERT THE LIST INTO TABLE
        //CALLING FUNCTIONS
        //FUNCTION : addPurchase, CLASS : SAME
        private DataTable listToTable(System.ComponentModel.BindingList<clsOrder> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("product_id", typeof(int));
            //dt.Columns.Add("hscin_id", typeof(int));
            //dt.Columns.Add("gst_slab", typeof(decimal));
            dt.Columns.Add("quantity", typeof(int));
            dt.Columns.Add("price", typeof(decimal));
            dt.Columns.Add("taxable_amt", typeof(decimal));
            //dt.Columns.Add("cgst", typeof(decimal));
            dt.Columns.Add("tax", typeof(decimal));
            dt.Columns.Add("amount", typeof(decimal));

            foreach (var row in list)
            {
                dt.Rows.Add(row.prod_id, row.Quantity, row.Price, row.Taxable_amt, (row.CGST + row.SGST), row.Amount);
            }

            return dt;
        }



        private void setProp(System.ComponentModel.BindingList<clsOrder> list)
        {
            foreach (var order in list)
            {
                this.taxable_amt += order.Taxable_amt;
                this.tax += order.Tax;                
            }
            this.total_amt = this.tax + this.taxable_amt;
        }


        //FUNCTION TO SHOW DETAILS OF A SPECIFIC PURCHASE
        //CALLING FUNCTION       
        //FUNCTION : CELL CLICK EVENT OF GRIDVIEW, CLASS : VIEW_PURCHASES - FORM
        public DataTable showPurchaseDetails(string billNo)
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_purchaseDetails" };
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@bill_no", SqlDbType.VarChar);
            objParam[0].Value = billNo;

            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.showPurchaseDetails, ds, tbl, objParam);
            return ds.Tables[0];
        }


        //FUNCTION TO ADD PAYMENT TO A PURCHASE
        //CALLING FUNCTION
        //FUNCTION : BUTTON CLICK EVENT Confirm Purchase Update, CLASS : VIEW_PURCHASES - FORM
        public int addPayment(string bill_no, decimal amt_paid, DateTime date)
        {
            SqlParameter[] objParam = new SqlParameter[3];

            objParam[0] = new SqlParameter("@bill_no", SqlDbType.VarChar);
            //objParam[1] = new SqlParameter("@S_id", SqlDbType.BigInt);
            objParam[1] = new SqlParameter("@n_paid_amt", SqlDbType.Decimal);
            objParam[2] = new SqlParameter("@Date", SqlDbType.Date);

            objParam[0].Value = bill_no;
            //objParam[1].Value = sales_id;
            objParam[1].Value = amt_paid;
            objParam[2].Value = date;
            try
            {
                return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.addPaymentToPurchase, objParam);
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }


        //FUNCTION TO SHOW PAYMENT HISTORY OF A TRANSACTION
        //CALLING FUNCTIONS
        //FUNCTION : CELL CLICK EVENT, CLASS : VIEW_PURCHASES - FORM
        public DataTable showPayments(string bill_no)
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_purchasePayments" };
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@bill_no", SqlDbType.VarChar);
            objParam[0].Value = bill_no;

            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getPurchasePaymentDetails, ds, tbl, objParam);
            return ds.Tables[0];
        }

    }
}
