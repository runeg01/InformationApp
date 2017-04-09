using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InformationApp.Models
{
    public class InformationAppDB : DbContext
    {
        public DbSet<Members> Members { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
    }
}