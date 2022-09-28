using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Books
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public String Title { get; set; }
        public String ISBN { get; set; }
        public String Year { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }

        public string Position { get; set; }

        public String Status { get; set; }
        public String Image { get; set; }

        public Books(int bookid,int categoryid ,String title,String isbn ,String year ,int price,string description , string position ,String status ,String image)
        {
            BookId = bookid;
            CategoryId = categoryid;
            Title = title;
            ISBN = isbn;
            Year = year;
            Price = price;
            Description = description;
            Position = position;
            Status = status;
            Image = image;
        }


    }
}