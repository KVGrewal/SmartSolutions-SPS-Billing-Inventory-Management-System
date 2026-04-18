using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartSolutionsSPS
{
    class ConnClass
    {
        static string connectionString = @"Data Source=DESKTOP-HOD499J\ADV25MSSQLSERVER;Initial Catalog=sample1;User Id=SSUser1;Password=Bharat12345;";
        //static string connectionString = @"Data Source=DESKTOP-EQ1RV6Q;Initial Catalog=sample1;User Id=SSUser1;Password=Bharat1234;";
       
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string getConnectionString()
        {
            return connectionString;
        }
    }
}
