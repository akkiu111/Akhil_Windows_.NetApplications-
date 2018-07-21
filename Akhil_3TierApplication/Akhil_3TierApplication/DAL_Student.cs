using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Akhil_3TierApplication
{
    class DAL_Student:ConnectionClass
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        int r;

        public int Dal_insert_student(BAL_Student obj)
        {
            try { 
            //start connection
            con = ProjectConnection();
            con.Open();

            //insert into table
            string query = "Insert_Student";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@val_sid",obj.bal_sid);
            cmd.Parameters.AddWithValue("@val_sname", obj.bal_sname);
            cmd.Parameters.AddWithValue("@val_sgrade", obj.bal_sgrade);
            r =cmd.ExecuteNonQuery();

            //close the connection
            con.Close();
            }
            catch(Exception ex)
            {
                r = 0;
            }
            return r;
        }

        public int Dal_update_student(BAL_Student obj)
        {
            try
            {
                //start connection
                con = ProjectConnection();
                con.Open();

                //insert into table
                string query = "Update_Student";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@val_sid", obj.bal_sid);
                cmd.Parameters.AddWithValue("@val_sname", obj.bal_sname);
                cmd.Parameters.AddWithValue("@val_sgrade", obj.bal_sgrade);
                r = cmd.ExecuteNonQuery();

                //close the connection
                con.Close();

            }

            catch (Exception ex)
            {
                r = 0;
            }

            return r;
        }
        public DataTable Dal_find_student(BAL_Student obj)
        {
            try
            {
                //start connection
                con = ProjectConnection();
                con.Open();

                //insert into table
                string query = "Find_Student";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@val_sid",obj.bal_sid);
                da = new SqlDataAdapter(cmd);
                r = cmd.ExecuteNonQuery();
                
                //close the connection
                con.Close();
                //Fill the data table

                dt = new DataTable();
                da.Fill(dt);
            }

            catch (Exception ex)
            {
                dt = null;
            }

            return dt;
        
    }
        public int Dal_delete_student(BAL_Student obj)
        {
            try
            {
                //start connection
                con = ProjectConnection();
                con.Open();

                //insert into table
                string query = "Delete_Student";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@val_sid", obj.bal_sid);

                r = cmd.ExecuteNonQuery();

                //close the connection
                con.Close();

            }

            catch (Exception ex)
            {
                r = 0;
            }

            return r;
        }
        public DataTable Dal_display_student()
        {
            try
            {
                //start connection
                con = ProjectConnection();
                con.Open();

                //insert into table
                string query = "Display_Student";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);

                //Fill the data table
                dt = new DataTable();
                da.Fill(dt);
            }

            catch (Exception ex)
            {
                dt = null;
            }

            return dt;
        }
    }
}
