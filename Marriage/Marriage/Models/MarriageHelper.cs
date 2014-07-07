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
        public int religion { get; set; }
        public int cast { get; set; }
        public int marrtail_status { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public int country { get; set; }
        public int state { get; set; }
        public string city { get; set; }
        public int education { get; set; }
        public int profession { get; set; }
    }

    
}