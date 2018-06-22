using LojaWeb.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
    
    public class EntityContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProdCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string conexao = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            optionsBuilder.UseSqlServer(conexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}