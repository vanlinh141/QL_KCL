using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KCL
{
    internal class ConnectionDB
    {

        public static SqlConnection builderDB()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LINH";
            builder.InitialCatalog = "KCL_DB";
            builder.IntegratedSecurity = true; 
            return new SqlConnection(builder.ToString());
        }
    }
}
