using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThuiszorgLogin.Models
{
    public class Profile
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
              
        public string role { get; set; }

        public string email { get; set; }

        public string city { get; set; }
 
        public string zipcode { get; set; }
        
        public string street { get; set; }
        
        public string homeNumber { get; set; }

        public string homeNumberExtra { get; set; }

        public string homeTelephone { get; set; }

        public string mobileTelephone { get; set; }

    }
}