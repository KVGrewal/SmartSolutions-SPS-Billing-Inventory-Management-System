using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{
    class clsPARTIES
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        //FUNCTION TO GET ALL CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : fillData, FORM : VIEW_PARTIES
        public static DataTable showParties()
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_customer" };
            SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.showParties, ds, tbl);
            return ds.Tables[0];
        }


        //FUNCTION TO GET ALL CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : CellContentClick, FORM : VIEW_PARTIES
        public static int removeCustomer(int id)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@id", SqlDbType.Int);
            objParam[0].Value = id;
            return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.removeCustomer, objParam);
        }

        //FUNCTION TO UPDATE AN EXISTING CUSTOMER
        //CALLING FUNCTIONS
        //FUNCTION : CellContentClick, FORM : VIEW_PARTIES
        public static int updateCustomer(int id, string name, string address)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@id", SqlDbType.Int);
            objParam[1] = new SqlParameter("@name", SqlDbType.VarChar);
            objParam[2] = new SqlParameter("@address", SqlDbType.VarChar);

            objParam[0].Value = id;
            objParam[1].Value = name;
            objParam[2].Value = address;

            return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.updateCustomer, objParam);            
        }        


        public static void fillUpdateData(System.Windows.Forms.TextBox txtPanelUpdateCName, System.Windows.Forms.TextBox txtPanelUpdateCAdd, int id)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@id", SqlDbType.Int);
            objParam[0].Value = id;
            string[] tbl = { "tbl_customer" };
            DataSet ds = new DataSet();
            try
            {
                SqlHelper.FillDataset(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.pullCust, ds, tbl, objParam);
                txtPanelUpdateCName.Text = ds.Tables[0].Rows[0]["customer_name"].ToString();
                txtPanelUpdateCAdd.Text = ds.Tables[0].Rows[0]["customer_address"].ToString();

            }
            catch (Exception e)
            {
                
            }
        }


        
    }


    
}
