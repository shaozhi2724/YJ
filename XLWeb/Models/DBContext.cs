using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XLWeb.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("name=XLYJConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}