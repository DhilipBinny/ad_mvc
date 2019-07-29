using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace demo1.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}