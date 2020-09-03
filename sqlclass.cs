using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CHITA
{
    class sqlclass
    {




        public SqlConnection connection = new SqlConnection();
        public sqlclass(string SqlConnectionString)
        {
            connection.ConnectionString = SqlConnectionString;
        }

        public DataTable Fill(string command)
        {
            SqlDataAdapter da = new SqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public SqlDataReader ReturnRow(string command)
        //{
        //    SqlCommand cmd = new SqlCommand(command, connection);
        //    connection.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    dr.Read();
            
        //    connection.Close();
        //    return dr;


            
        //}

        public Boolean Login(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }


        public bool SavetoDB(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public SqlDataReader StartEdit(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            connection.Close();
            return dr;
        }

        public bool ConfirmEdit(String command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public bool Delete(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }

}
