using LojaVirtualEntity.Entities;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualEntity {
    public class EntitiesContext : DbContext {
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string sconn = ConfigurationManager.ConnectionStrings["dbLojaVirtualEntityConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(sconn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}