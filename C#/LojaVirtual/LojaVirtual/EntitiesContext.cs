using LojaVirtual.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual {
    public class EntitiesContext : DbContext {
        public DbSet<User> Users { get; set; }

        //NuGet Console:
        //Install-Package EntityFramework.MicrosoftSqlserver -Version 7.0.0-rc1-final -Pre
        //Install-Package EntityFramework.Commands -Version 7.0.0-rc1-final -Pre
        protected override void 
    }
}
