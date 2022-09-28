using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore.Models
{
    public class UserdetSqlImpl:IUserdetRepository
    {

        SqlConnection conn;
        SqlCommand comm;

        public List<Userdet> GetAllUserdet()
        {
            List<Userdet> list = new List<Userdet>();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
            comm.CommandText = "select * from Userdet";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string cusername = reader["Cusername"].ToString();
                string cpassword = reader["Cpassword"].ToString();
                list.Add(new Userdet(cusername, cpassword));
            }
            conn.Close();
            return list;

        }
    }
}