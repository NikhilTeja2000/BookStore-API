using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore.Models
{
    public class CategorySqlImpl : ICategoryRepository
    {
        SqlConnection conn;
        SqlCommand comm;

        public CategorySqlImpl()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            comm = new SqlCommand();
        }

        public Category AddCategory(Category category)
        {
            comm.CommandText = "insert into Category (CategoryName,[Description],[Image],[Status],Position,CreatedAt) values( '" + category.CategoryName + "','" + category.Description + "', '" + category.Image + "','" + category.Status + "', '" + category.Position + "','" + category.CreatedAt + "')";
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            if (row > 0)
            {
                return category;
            }
            else
            {
                return null;
            }
        }

        public int DeleteCategory(int id)
        {
            comm.CommandText = "delete from Category where CategoryId =" + id;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            return row;

        }

        public List<Category> GetAllCategory()
        {
            List<Category> list = new List<Category>();
            comm.CommandText = "select * from Category";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int categoryid = Convert.ToInt32(reader["CategoryId"]);
                string categoryname = reader["CategoryName"].ToString();
                string description = reader["Description"].ToString();
                string image = reader["Image"].ToString();
                string status = reader["Status"].ToString();
                string position = reader["Position"].ToString();
                string createdAt = reader["CreatedAt"].ToString();
                list.Add(new Category(categoryid,categoryname,description, image,status,position,createdAt));
            }
            conn.Close();
            return list;
        }

        

        public int UpdateCategory(int id,Category category)
        {
            comm.CommandText = "update Category set CategoryName='" + category.CategoryName + "', Description='" + category.Description + "', Image='" + category.Image+ "',Status='" + category.Status + "', Position='" + category.Position + "', CreatedAt='" + category.CreatedAt + "' where CategoryId=" + category.CategoryId;
            comm.Connection = conn;
            conn.Open();
            int row = comm.ExecuteNonQuery();
            conn.Close();
            return row;

        }

        Category ICategoryRepository.GetCategoryByCategoryId(int id)
        {
            comm.CommandText = "select * from Category where CategoryId="+id;
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                int categoryid = Convert.ToInt32(reader["CategoryId"]);
                string categoryname = reader["CategoryName"].ToString();
                string description = reader["Description"].ToString();
                string image = reader["Image"].ToString();
                string status = reader["Status"].ToString();
                string position = reader["Position"].ToString();
                string createdAt = reader["CreatedAt"].ToString();
                Category category=new Category(categoryid, categoryname, description, image, status, position, createdAt);
                return category;
            }

           
            conn.Close();
      
            return null;

        }
    }
}