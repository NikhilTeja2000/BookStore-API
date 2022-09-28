using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore.Models
{
    public class BooksSqlImpl : IBooksRepository
    {
        SqlConnection conn;
        SqlCommand comm;
        

        public BooksSqlImpl()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public Books AddBooks(Books books)
        {
            comm.CommandText = "insert into Books (CategoryId,Title,ISBN,[Year],Price,[Description],[Image],[Status],Position) values( " + books.CategoryId + ",'" + books.Title + "', '" + books.ISBN + "','" + books.Year + "', " + books.Price + ",'" + books.Description + "', '" + books.Image + "','" + books.Status + "', '" +books.Position + "')";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return books;
            }
            else
            {
                return null;
            }
        }

        public int DeleteBooks(int id)
        {
            comm.CommandText = "delete from Books where BookId =" +id;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        public List<Books> GetAllBooks()
        {
            List<Books> list = new List<Books>();
            comm.CommandText = "select * from Books";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int bookid = Convert.ToInt32(reader["BookId"]);
                int categoryid = Convert.ToInt32(reader["CategoryId"]);
                string title = reader["Title"].ToString();
                string isbn = reader["ISBN"].ToString();
                string year = reader["Year"].ToString();
                int price = Convert.ToInt32(reader["Price"]);
                string description = reader["Description"].ToString();
                string image = reader["Image"].ToString();
                string status = reader["Status"].ToString();
                string position = reader["Position"].ToString();
                list.Add(new Books(bookid,categoryid, title,isbn,year,price, description, image, status, position));
            }
            conn.Close();
            return list;
        }

      

        public Books GetAllBooksByBookId(int id)
        {
            comm.CommandText = "select * from Books where Bookid="+id;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int bookid = Convert.ToInt32(reader["BookId"]);
                int categoryid = Convert.ToInt32(reader["CategoryId"]);
                string title = reader["Title"].ToString();
                string isbn = reader["ISBN"].ToString();
                string year = reader["Year"].ToString();
                int price = Convert.ToInt32(reader["Price"]);
                string description = reader["Description"].ToString();
                string image = reader["Image"].ToString();
                string status = reader["Status"].ToString();
                string position = reader["Position"].ToString();
                Books books = new Books(bookid, categoryid, title, isbn, year, price, description, image, status, position);
                return books;
            }
            conn.Close();
            return null;

        }

        public void UpdateBooks(Books books,int id)
        {
            comm.CommandText = "update Books set CategoryId=" + books.CategoryId + ",Title='" + books.Title + "',ISBN='" + books.ISBN + "',Year=" + books.Year + ",Price=" + books.Price + ",Description='" + books.Description + "',Position='" + books.Position + "',Status='" + books.Status + "',Image='" + books.Image + "' where BookId=" + books.BookId;
            comm.Connection = conn;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            

        }

    }
}