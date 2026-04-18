using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SmartSolutionsSPS
{
    class clsAddCustomer
    {
        public string name { get; set; }
        public string address { get; set; }
        public int  customer_id { get; set; }


        /// <summary>
        /// THIS FUNCTION ADDS A CUSTOMER
        /// CALLING CLASSES
        /// ADD_PARTY
        /// </summary>
        /// <returns></returns>
        public int addCustomer()
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@NAME", SqlDbType.VarChar);
            objParam[1] = new SqlParameter("@ADDRESS", SqlDbType.VarChar);

            objParam[0].Value = name;
            objParam[1].Value = address;

            int res = SqlHelper.ExecuteNonQuery(ConnClass.getConnection(), CommandType.StoredProcedure, clsProcedures.addCustomer, objParam);
            return res;
        }

    }
}
