using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BookStore.Models
{
    public class UserCartSqlImpl : IUserCartRepository
    {

        SqlConnection conn;
        SqlCommand comm;


        public UserCartSqlImpl()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }
        public int DeleteUserCart(int id)
        {
            
                comm.CommandText = "delete from UserCart where Cartid =" + id;
                comm.Connection = conn;
                conn.Open();
                int row = comm.ExecuteNonQuery();
                conn.Close();
                return row;
            
        }

        public List<UserCart> GetAllUserCart()
        {
            List<UserCart> list = new List<UserCart>();
            comm.CommandText = "select * from UserCart";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CartId"]);
                int bookid = Convert.ToInt32(reader["BookId"]);
                int quantity = Convert.ToInt32(reader["Quantity"]);

                string cusername = reader["Cusername"].ToString();
                list.Add(new UserCart(id, cusername, bookid, quantity));
            }
            conn.Close();
            return list;
        }
    }
}