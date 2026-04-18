using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SmartSolutionsSPS
{
    class clsDashboard
    {
        static SqlConnection conn = ConnClass.getConnection();

        public string _CName { get; set; }


        public static void fillComboBox(System.Windows.Forms.ComboBox comboBox, string table, string column)
        {
            conn.Open();
            string query = "SELECT distinct " + column + " from " + table + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();
            comboBox.DataSource = dt;
            comboBox.DisplayMember = column;
            comboBox.ValueMember = column;
        }

        public static void fillComboBox(System.Windows.Forms.ComboBox comboBox, string table, string column, string condition_column, string condition)
        {
            conn.Open();
            string query = "SELECT " + column + " FROM " + table + " WHERE " + condition_column + " = '" + condition + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            conn.Close();

            comboBox.DataSource = dt;
            comboBox.DisplayMember = column;
            comboBox.ValueMember = column;
        }

        /// <summary>
        /// FILL CUSTOMER DATA
        /// </summary>
        /// <returns></returns>
        public DataTable fillCustomer()
        {            
            string query = "SELECT [customer_id],[customer_name],[customer_address] FROM [dbo].[tbl_customer]";
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_customer" };
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.Text , query, ds, tbl);      
            return ds.Tables[0];
        }


        #region GET CUSTOMER DATA BY NAME
        /// <summary>
        /// GET CUSTOMER DATA BY NAME
        /// </summary>
        /// <returns></returns>
        public DataTable getCustomer()
        {
            //conn.Open();
            string query = "SELECT [customer_id],[customer_name],[customer_address] FROM [dbo].[tbl_customer] where customer_name='"+ _CName +"'";
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_customer" };
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.Text, query, ds, tbl);
            return ds.Tables[0];         
        }
        #endregion

        #region
        /// <summary>
        /// GIVES PRODUCT DETAILS TO ITS CALLING FUNCTIONS
        /// CALLING FUNCTIONS
        /// DASHBOARD
        /// MANAGE STOCK
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable showProducts()
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_products" };
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.showProducts, ds, tbl);
            return ds.Tables[0];
        }


        public DataTable showBrand(string product)
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_products" };
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@name", SqlDbType.VarChar);
            objParam[0].Value = product;
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.showBrand, ds, tbl, objParam);
            return ds.Tables[0];
        }

        #endregion

        //FUNCTION TO GET THE AMOUNT TO BE COLLECTED FROM CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : getToCollect, CLASS : DASHBOARD - FORM
        public string getToCollect()
        {
            object result = SqlHelper.ExecuteScalar(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.getToCollectAmt);
            string strAmount = result != DBNull.Value ? result.ToString() : "0";
            return strAmount;
        }


    }
}
