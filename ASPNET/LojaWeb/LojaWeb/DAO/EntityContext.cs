using LojaWeb.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {

    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class EntityContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProdCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public EntityContext() : base("dblojawebConn") { }
    }
}