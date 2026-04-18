using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSolutionsSPS
{
    class clsStatistics
    {

        //FUNCTION TO GET THE AMOUNT TO BE COLLECTED FROM CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : getToCollect, CLASS : Statistics - FORM
        public string getToCollect()
        {
            object result = SqlHelper.ExecuteScalar(ConnClass.getConnection(), System.Data.CommandType.StoredProcedure, clsProcedures.getToCollectAmt);
            string strAmount = result != DBNull.Value ? result.ToString() : "0";
            return strAmount;
        }

        //FUNCTION TO GET THE AMOUNT TO BE COLLECTED FROM CUSTOMERS
        //CALLING FUNCTIONS
        //FUNCTION : getToPay, CLASS : Statistics - FORM
        public string getToPay()
        {
            object result = SqlHelper.ExecuteScalar(ConnClass.getConnection(), System.Data.CommandType.StoredProcedure, clsProcedures.getToPayAmt);
            string strAmount = result != DBNull.Value ? result.ToString() : "0";
            return strAmount;
        }

        //FUNCTION TO GET THE TAX TO PAID
        //CALLING FUNCTIONS
        //FUNCTION : getTax, CLASS : Statistics - FORM
        internal string getTax()
        {
            object result = SqlHelper.ExecuteScalar(ConnClass.getConnection(), System.Data.CommandType.StoredProcedure, clsProcedures.getTax);
            string strAmount = result != DBNull.Value ? result.ToString() : "0";
            return strAmount;
        }
    }
}
