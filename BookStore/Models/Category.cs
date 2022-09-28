using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public String Status { get; set; }
        public string Position { get; set; }
        public string CreatedAt { get; set; }

        public Category(int categoryid,String categoryname,String description ,String image , String status ,string position,string createdAt)
        {
            CategoryId = categoryid;
            CategoryName = categoryname;
            Description = description;
            Image = image;
            Status = status;
            Position = position;
            CreatedAt = createdAt;

        }
        

    }

}