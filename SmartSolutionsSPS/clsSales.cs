using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{
    class clsSales
    {
        public decimal taxable_amt { get; set; }
        public decimal cgst { get; set; }
        public decimal sgst { get; set; }
        public decimal amount { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public int customer_id { get; set; }
        public decimal paid { get; set; }
        public DateTime date { get; set; }

        public int saveTransaction()
        {
            //SqlParameter[] objParam = new SqlParameter[12];
            //objParam[0] = new SqlParameter("@Pid", SqlDbType.Int);
            //objParam[1] = new SqlParameter("@HSCIN", SqlDbType.Int);
            //objParam[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            //objParam[3] = new SqlParameter("@Status", SqlDbType.Int);
            //objParam[4] = new SqlParameter("@Taxable_amt", SqlDbType.Decimal);
            //objParam[5] = new SqlParameter("@Cgst", SqlDbType.Decimal);
            //objParam[6] = new SqlParameter("@Sgst", SqlDbType.Decimal);
            //objParam[7] = new SqlParameter("@Amount", SqlDbType.Decimal);
            //objParam[8] = new SqlParameter("@P_amount", SqlDbType.Decimal);
            //objParam[9] = new SqlParameter("@C_name", SqlDbType.VarChar);
            //objParam[10] = new SqlParameter("@C_add", SqlDbType.VarChar);
            //objParam[11] = new SqlParameter("@Dop", SqlDbType.Date);

            //objParam[0].Value = this.p_id;
            //objParam[1].Value = this.hsn_id;
            //objParam[2].Value = this.quantity;
            //objParam[3].Value = this.status;
            //objParam[4].Value = this.taxable_amt;
            //objParam[5].Value = this.cgst;
            //objParam[6].Value = this.sgst;
            //objParam[7].Value = this.amount;
            //objParam[8].Value = this.paid;
            //objParam[9].Value = this.customer_name;
            //objParam[10].Value = this.customer_address;
            //objParam[11].Value = this.date;
            //int res = 0;
            //res = SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.addSale, objParam);
            //return res;
            return 0;
        }


        //FUNCTION TO SHOW ALL SALES AND DETAILS OF A SPECIFIC SALE
        //CALLING FUNCTION
        //FUNCTION : showSales, CLASS : VIEW_SALES - FORM
        //FUNCTION : CELL CLICK EVENT OF GRIDVIEW, CLASS : VIEW_SALES - FORM
        //FUNCTON : load_data, CLASS : Statistics - FORM
        public DataTable fillData(int cond)
        {
            DataSet ds = new DataSet();            

            //GETS ALL THE SALES
            if (cond == 0)
            {
                string[] tbl = { "tbl_transaction" };
                SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.showAllSales, ds, tbl);
                return ds.Tables[0];
            }

            //GETS THE DETAILS OF A SPECIFIC SALE
            else
            {
                string[] tbl = { "tbl_orders" };
                SqlParameter[] objParam = new SqlParameter[1];
                objParam[0] = new SqlParameter("@SalesId", SqlDbType.Int);
                objParam[0].Value = cond;

                SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.showDetails, ds, tbl, objParam);
                return ds.Tables[0];
            }
                      
        }

        public static void Invoice(DataTable table, System.Windows.Forms.DataGridView dataGridViewInvoice)
        {
            SqlParameter[] objParam = new SqlParameter[1];

            objParam[0] = new SqlParameter("@user_id_list", SqlDbType.Structured);
            objParam[0].Value = table;

            DataSet ds = new DataSet();
            string[] arr = { "tbl_customer", "tbl_sales" };
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.selectById, ds, arr, objParam);
            dataGridViewInvoice.DataSource = ds.Tables[0];

            //SqlConnection conn = ConnClass.getConnection();
            //SqlCommand cmd = new SqlCommand(clsProcedures.selectById, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@user_id_list", table);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adp.Fill(ds);                        
            //dataGridViewInvoice.DataSource = ds.Tables[0];
        }


        //FUNCTION TO ADD PAYMENT TO A TRANSACTION
        //CALLING FUNCTION
        //FUNCTION : BUTTON CLICK EVENT Confirm Sale Update, CLASS : VIEW_SALES - FORM
        public int addPayment(int customer_id, int sales_id, decimal amt, DateTime dateTime)
        {
            SqlParameter[] objParam = new SqlParameter[4];

            objParam[0] = new SqlParameter("@C_id", SqlDbType.BigInt);
            objParam[1] = new SqlParameter("@S_id", SqlDbType.BigInt);
            objParam[2] = new SqlParameter("@n_paid_amt", SqlDbType.Decimal);
            objParam[3] = new SqlParameter("@Date", SqlDbType.Date);

            objParam[0].Value = customer_id;
            objParam[1].Value = sales_id;
            objParam[2].Value = amt;
            objParam[3].Value = dateTime;
            return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.addPayment, objParam);
        }


        //FUNCTION TO SUM UP AND SET THE TAXABLE AMT, CGST, SGST AND AMOUNT
        //CALLING FUNCTION
        //FUNCTION : BUTTON CLICK EVENT SUMMARY, CLASS : DASHBOARD - FORM
        public void setProp(System.ComponentModel.BindingList<clsOrder> list)
        {
            foreach (var order in list)
            {
                this.taxable_amt += order.Taxable_amt;
                this.cgst += order.CGST;
                this.sgst += order.SGST;
                this.amount += order.Amount;                
            }
        }


        //FUNCTION TO SAVE TRANSACTION
        //CALLING FUNCTIONS
        //FUNCTION : BUTTON CLICK EVENT SAVE TRANSACTION, CLASS : DASHBOARD - FORM
        public int saveSale(System.ComponentModel.BindingList<clsOrder> list, int C_id)
        {
            DataTable dt =  listToTable(list);
            SqlParameter[] objParam = new SqlParameter[11];

            this.customer_id = C_id;            

            objParam[0] = new SqlParameter("@taxable_amt", SqlDbType.Decimal);
            objParam[1] = new SqlParameter("@cgst", SqlDbType.Decimal);
            objParam[2] = new SqlParameter("@sgst", SqlDbType.Decimal);
            objParam[3] = new SqlParameter("@amount", SqlDbType.Decimal);
            objParam[4] = new SqlParameter("@customer_id", SqlDbType.Int);            
            objParam[5] = new SqlParameter("@paid", SqlDbType.Decimal);
            objParam[6] = new SqlParameter("@date", SqlDbType.Date);
            objParam[7] = new SqlParameter("@list", SqlDbType.Structured);
            objParam[8] = new SqlParameter("@customer_name", SqlDbType.VarChar);
            objParam[9] = new SqlParameter("@customer_add", SqlDbType.VarChar);
            objParam[10] = new SqlParameter("@id_return", SqlDbType.Int);
            objParam[10].Direction = ParameterDirection.Output;

            

            objParam[0].Value = this.taxable_amt;
            objParam[1].Value = this.cgst;
            objParam[2].Value = this.sgst;
            objParam[3].Value = this.amount;
            objParam[4].Value = this.customer_id;            
            objParam[5].Value = this.paid;
            objParam[6].Value = this.date;
            objParam[7].Value = dt;
            objParam[8].Value = this.customer_name;
            objParam[9].Value = this.customer_address;

            SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.saveSale, objParam);
            int saleId = Convert.ToInt32(objParam[10].Value);
            return saleId;
        }

        private int getId(string name, string address)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@name", SqlDbType.VarChar);
            objParam[1] = new SqlParameter("@address", SqlDbType.VarChar);
            objParam[0].Value = name;
            objParam[1].Value = address;
            String[] tbl = {"tbl_customer"};
            int id;
            DataSet ds = new DataSet();
            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getId, ds, tbl, objParam);
            id = Convert.ToInt32(ds.Tables[0].Rows[0]["customer_id"]);
            return id;
        }

        //FUNCTION TO CONVERT THE LIST INTO TABLE
        //CALLING FUNCTIONS
        //FUNCTION : saveTransaction, CLASS : SAME
        private DataTable listToTable(System.ComponentModel.BindingList<clsOrder> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("product_id", typeof(int));
            dt.Columns.Add("hscin_id", typeof(int));
            dt.Columns.Add("gst_slab", typeof(decimal));
            dt.Columns.Add("quantity", typeof(int));
            dt.Columns.Add("price", typeof(decimal));
            dt.Columns.Add("taxable_amt", typeof(decimal));
            dt.Columns.Add("cgst", typeof(decimal));
            dt.Columns.Add("sgst", typeof(decimal));
            dt.Columns.Add("amount", typeof(decimal));

            foreach (var row in list)
            {
                dt.Rows.Add(row.prod_id, row.hsn, (decimal)row.GST, row.Quantity, row.Price, row.Taxable_amt, row.CGST, row.SGST, row.Amount);
            }

            return dt;
        }


        //FUNCTION TO SHOW PAYMENT HISTORY OF A TRANSACTION
        //CALLING FUNCTIONS
        //FUNCTION : CELL CLICK EVENT, CLASS : VIEW_SALES - FORM
        public DataTable showPayments(int s_id)
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_payments" };
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@SalesId", SqlDbType.BigInt);
            objParam[0].Value = s_id;

            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getPaymentDetails, ds, tbl, objParam);
            return ds.Tables[0];
        }



        public DataTable generateBill(int s_id)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@sales_id", SqlDbType.Int);
            objParam[0].Value = s_id;
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_customer", "tbl_orders", "tbl_transaction", "tbl_product P" };
            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.generateBill, ds, tbl,objParam);
            return ds.Tables[0];
        }
    }
}
