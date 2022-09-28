using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Userdet
    {
        public string Cusername { get; set; }

        public string Cpassword { get; set; }

        public Userdet(string cusername, string cpassword)
        {
            Cusername = cusername;
            Cpassword = cpassword;

        }
    }
}