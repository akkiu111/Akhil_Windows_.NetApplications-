using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Akhil_2_Tier_EmployeeDB
{
    class ConnectionClass
    {
public SqlConnection ProjectConnection()
        {
            string con_path = ConfigurationManager.ConnectionStrings["Akhil_2TierEmpDB"].ConnectionString;
            SqlConnection con = new SqlConnection(con_path);
            return con;
        }
    }
}
