using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marriage.Models
{
    public class LogIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class catageory
    {
        public int looking_for { get; set; }
        public string religion { get; set; }
        public string cast { get; set; }
        public int marrtail_status { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string education { get; set; }
        public string profession { get; set; }
    }
}