using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class UserCart
    {
        public int CartId { get; set; }
        public string Cusername { get; set; }
        public int BookId{ get; set; }
        public int Quantity { get; set; }

        public UserCart(int cartid, string cusername, int bookid, int quantity)
        {
            CartId = cartid;
            Cusername = cusername;
            BookId = bookid;
            Quantity = quantity;
        }
    }
}