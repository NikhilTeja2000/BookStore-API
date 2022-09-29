using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore.Models
{
    public class UserOrderSqlImpl:IUserOrderRepository
    {

        SqlConnection conn;
        SqlCommand comm;

        public List<UserOrder> GetAllUserOrder()
        {
            List<UserOrder> list = new List<UserOrder>();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
            comm.CommandText = "select * from UserOrder";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string cusername = reader["Cusername"].ToString();
                string city = reader["City"].ToString();
                int pincode = Convert.ToInt32(reader["Pincode"]);


                string houseno = reader["Houseno"].ToString();
                string boktitle = reader["Boktitle"].ToString();

                int quantity = Convert.ToInt32(reader["Quantity"]);

                int price = Convert.ToInt32(reader["Price"]);


                list.Add(new UserOrder(cusername, city, pincode, houseno, boktitle, quantity, price));
            }
            conn.Close();
            return list;
        }
    }
}