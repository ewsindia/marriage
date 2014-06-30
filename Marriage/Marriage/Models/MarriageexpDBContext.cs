using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Marriage.Models;
using MySql.Data.Entity;


namespace Marriage.Models
{
    public class MarriageexpDBContext : DbContext
    {
        public DbSet<country> country { get; set; }
        public DbSet<fevoritelist> fevoritelist { get; set; }
        public DbSet<friendlist> friendlist { get; set; }
        public DbSet<members> members { get; set; }
        public DbSet<messages> messages { get; set; }
        public DbSet<singlefieldmaster> singlefieldmaster { get; set; }
        public DbSet<statesprovinces> statesprovinces { get; set; }
        public DbSet<useprofile> useprofile { get; set; }
        public DbSet<multiuploads> multiuploads { get; set; }
        public DbSet<admin> admin { get; set; }
        public DbSet<agent_master> agent_master { get; set; }
        public DbSet<simple> simple { get; set; }
    }
}