using LojaWeb.Models;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {

    public class EntityContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<ProdCategory> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string conexao = ConfigurationManager.ConnectionStrings["DataBaseSQL"].ConnectionString;
            optionsBuilder.UseSqlServer(conexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}