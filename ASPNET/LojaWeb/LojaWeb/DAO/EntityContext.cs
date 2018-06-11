using LojaWeb.Models;
using Microsoft.Data.Entity;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
    public class EntityContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProdCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string stringConn = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            optionsBuilder.(stringConn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}