using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class UserOrder
    {
        
        public string Cusername { get; set; }
        public string City { get; set; }

        public string Houseno { get; set; }
        public int Pincode { get; set; }
        public string Boktitle { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }

        public UserOrder(string cusername, string city ,int pincode , string houseno ,string boktitle ,int quantity,int price)
        {
            Cusername = cusername;
            City = city;
            Pincode = pincode;
            Houseno = houseno;
            Boktitle = boktitle;
            Quantity = quantity;
            Price = price;

        }

    }
}