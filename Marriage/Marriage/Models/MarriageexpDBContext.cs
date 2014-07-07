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
        public DbSet<Country> Country { get; set; }
        public DbSet<FevoriteList> Fevoritelist { get; set; }
        public DbSet<FriendList> Friendlist { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<SingleFieldMaster> SingleFieldMaster { get; set; }
        public DbSet<StatesProvinces> StatesProvinces { get; set; }
        public DbSet<MultiUploads> MultiUploads { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<AgentMaster> AgentMaster { get; set; }
       
    }
}