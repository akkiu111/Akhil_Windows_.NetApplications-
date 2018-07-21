using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Akhil_EmployeeManagement
{
    class ConnectionClass
    {
        // EmpDB connection function
        public SqlConnection EmpDbConnection()
        { 
        string con_path = ConfigurationManager.ConnectionStrings["EmpDBConnection"].ConnectionString;
        SqlConnection con = new SqlConnection(con_path);
            return con;
        }

    }
}
