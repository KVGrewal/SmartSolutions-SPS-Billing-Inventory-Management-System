using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SmartSolutionsSPS
{
    class INVENTORY_CLS
    {        
        //FUNCTION TO GET ALL PRODUCTS
        //CALLING FUNCTIONS
        //FUNCTION : fillGrid, CLASS : INVENTORY - FORM
        public DataTable fillGrid()
        {
            DataSet ds = new DataSet();
            string[] tbl = { "tbl_product" };
            SqlHelper.FillDataset(ConnClass.getConnectionString(), CommandType.StoredProcedure, clsProcedures.getProducts, ds, tbl);
            return ds.Tables[0];
        }

    }
}
