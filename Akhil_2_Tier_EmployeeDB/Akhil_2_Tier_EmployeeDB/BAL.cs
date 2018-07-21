using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Akhil_2_Tier_EmployeeDB
{
    class BAL: ConnectionClass
    {
        //Member Variables

        public int bal_eid
        {
            get;
            set;
        }

        public string bal_ename
        {
            get;
            set;
        }

        public double bal_esalary
        {
            get;
            set;
        }

        

        public string Bal_insert_Emp()
        {
            //open class
            SqlConnection con = ProjectConnection();
            con.Open();

            //insert query
            string query = "insert into Employee_tbl values(@val_eid,@val_ename,@val_esalary)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eid",bal_eid);
            cmd.Parameters.AddWithValue("@val_ename", bal_ename);
            cmd.Parameters.AddWithValue("@val_esalary", bal_esalary);
            cmd.ExecuteNonQuery();

            //close con
            con.Close();

            return "Employee Details inserted successfully";
        }

        public string Bal_update_Emp()
        {
            //open class
            SqlConnection con = ProjectConnection();
            con.Open();

            //insert query
            string query = "update Employee_tbl set Ename=@val_ename,Esalary=@val_esalary where Eid=@val_eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eid", bal_eid);
            cmd.Parameters.AddWithValue("@val_ename", bal_ename);
            cmd.Parameters.AddWithValue("@val_esalary", bal_esalary);
            cmd.ExecuteNonQuery();

            //close con
            con.Close();

            return "Employee Details updated successfully";
        }


        public void Bal_find_Emp()
        {
            //open class
            SqlConnection con = ProjectConnection();
            con.Open();

            //select query
            string query = "select * from Employee_tbl where Eid=@val_eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eid", bal_eid);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                bal_ename = dr["Ename"].ToString();
                bal_esalary = double.Parse(dr["Esalary"].ToString());
            }
            else
            {
                bal_ename = "";
                bal_esalary = 0;
            }
            //close con
            con.Close();

        }

        public string Bal_delete_Emp()
        {
            //open class
            SqlConnection con = ProjectConnection();
            con.Open();

            //insert query
            string query = "delete from Employee_tbl where Eid=@val_eid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eid", bal_eid);
            cmd.ExecuteNonQuery();

            //close con
            con.Close();

            return "Employee Details deleted successfully";
        }


        public DataTable Bal_display_Emp()
        {
            //open class
            SqlConnection con = ProjectConnection();
            con.Open();

            //select query
            string query = "select * from Employee_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //close con
            con.Close();

            return dt;
        }

       

    }
}
