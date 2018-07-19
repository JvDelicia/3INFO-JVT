using Microsoft.Data.Entity;
using RenatinhaPlace.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace {
    public class EntitiesContext : DbContext {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Func> Funcs { get; set; }
        public DbSet<FuncType> FuncTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<ItemMenu> ItemMenus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ItemAcc> ItemAccs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        //NuGet Console:
        //Install-Package EntityFramework.MicrosoftSqlserver -Version 7.0.0-rc1-final -Pre
        //Install-Package EntityFramework.Commands -Version 7.0.0-rc1-final -Pre
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string stringConnection = ConfigurationManager.ConnectionStrings["dbDragonNightConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConnection);
			base.OnConfiguring(optionsBuilder);
        }
    }
}
