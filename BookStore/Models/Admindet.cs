using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Admindet

    {
        public string Adusername { get; set; }

        public string  Adpassword { get; set; }

        public Admindet(string adusername,string adpassword)
        {
            Adusername=adusername;
            Adpassword=adpassword;

        }

    }
}