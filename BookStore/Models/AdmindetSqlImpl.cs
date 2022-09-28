using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore.Models
{
    public class AdmindetSqlImpl : IAdmindetRepository
    {

        SqlConnection conn;
        SqlCommand comm;


        public List<Admindet> GetAllAdmindet()
        {

            List<Admindet> list = new List<Admindet>();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
            comm.CommandText = "select * from Admindet";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string adusername = reader["Adusername"].ToString();
                string adpassword = reader["Adpassword"].ToString();
                list.Add(new Admindet(adusername,adpassword));
            }
            conn.Close();
            return list;
        }
    }
}