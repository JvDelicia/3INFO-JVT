using LojaWeb.Models;
using Microsoft.Data.Entity.Infrastructure;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {

    public class EntityContext: DbContext {

        public DbSet<Product> Products { get; set; }
        public DbSet<ProdCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        //https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework60.html
        //https://dev.mysql.com/doc/connector-net/en/connector-net-entity-framework.html
    }
}