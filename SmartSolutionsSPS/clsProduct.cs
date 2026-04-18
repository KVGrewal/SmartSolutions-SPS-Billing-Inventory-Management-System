using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartSolutionsSPS
{

    public class clsProduct
    {        
        /// <summary>
        /// THIS CLASS ADD, REMOVES AND UPDATE STOCK OF A PRODUCT
        /// </summary>

        public string Product_name { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public int hsn { get; set; }
        public int stock { get; set; }
        public decimal gst { get; set; }

       

        //FUNCTION TO ADD A NEW PRODUCT
        //CALLING FUNCTION
        // FUNCTION : BUTTON CLICK EVENT, CLASS : AddProduct.cs form
        public void Add_Prod_Data()
        {
            SqlParameter[] objParam = new SqlParameter[5];

            objParam[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            objParam[1] = new SqlParameter("@Brand", SqlDbType.VarChar);
            //objParam[2] = new SqlParameter("@Price", SqlDbType.Decimal);
            objParam[2] = new SqlParameter("@Gst", SqlDbType.Decimal);
            objParam[3] = new SqlParameter("@HSN", SqlDbType.Int);
            objParam[4] = new SqlParameter("@Stock", SqlDbType.Int);

            objParam[0].Value = Product_name;
            objParam[1].Value = brand;
            //objParam[2].Value = price;
            objParam[2].Value = gst;
            objParam[3].Value = hsn;
            objParam[4].Value = stock;

            try
            {
                int res = SqlHelper.ExecuteNonQuery(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures._AddProd, objParam);
                if (res > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
        
        //FUNCTION TO REMOVE A PRODUCT FROM THE DATABASE
        //CALLING FUNCTIONS
        //FUNCTION : BUTTON CLICK EVENT TO REMOVE PRODUCT, CLASS : INVENTORY - FORM
        public static int removeProduct(int id)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@id", SqlDbType.Int);
            objParam[0].Value = id;
            return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.removeProdById, objParam);
        }        

        //FUNCTION TO UPDATE STOCK OF A PRODUCT
        //CALLING FUNCTIONS
        //FUNCTION : BUTTON CLICK EVENT UPDATE, CLASS : ADD_STOCK - FORM
        public int updateStock(int id, int quantity)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@id", SqlDbType.BigInt);
            objParam[1] = new SqlParameter("@quantity", SqlDbType.Int);

            objParam[0].Value = id;
            objParam[1].Value = quantity;
            return SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.updateStock, objParam);
        }

        //FUNCTION TO SEE GST SLAB CORRESPONDIG TO A HSN
        //CALLING FUNCTIONS
        //FUNCTION : BUTTON CLICK EVENT TO UPDATE GST SLABS, CLASS : INVENTORY - FORM
        public DataTable getHSN()
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_HSCIN" };
            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getHSN, ds, tbl);
            return ds.Tables[0];
        }

        //FUNCTION TO UPDATE GST SLAB CORRESPONDIG TO A HSN
        //CALLING FUNCTIONS
        //FUNCTION : BUTTON CLICK EVENT TO UPDATE GST SLABS, CLASS : INVENTORY - FORM
        public void updateGstSlab(int hsn, int new_rate)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@HSN", SqlDbType.BigInt);
            objParam[1] = new SqlParameter("@GstSlab", SqlDbType.Int);

            objParam[0].Value = hsn;
            objParam[1].Value = new_rate;
            SqlHelper.ExecuteScalar(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.updateGstSlab, objParam);
        }
    }
}
