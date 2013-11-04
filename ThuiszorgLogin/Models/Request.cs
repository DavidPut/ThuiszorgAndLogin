using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThuiszorgLogin.Models
{
    public class Request
    {
        public int ID { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        public DateTime dateAndTimeAdded { get; set; }

        [Required]
        public DateTime dateAndTimeRequest { get; set; }

        [Required]
        public string timeRequest { get; set; }

        public string user { get; set; }

        public bool completed { get; set; }

        public bool accept { get; set; }


    }
}