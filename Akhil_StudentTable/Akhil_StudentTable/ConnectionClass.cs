using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Akhil_StudentTable
{
    class ConnectionClass
    {
        public SqlConnection studentDBConnection()
        {
            //get connection path
            string con_path = ConfigurationManager.ConnectionStrings["StudentDB Connection"].ConnectionString;

            //Open Connection
            SqlConnection con = new SqlConnection(con_path);
            return con;
        }
    }
}
