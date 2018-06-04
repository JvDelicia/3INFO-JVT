using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using System.Configuration;
using AvaliaçãoAlunoNota.Entidades;

namespace AvaliaçãoAlunoNota {
    public class EntitiesContext : DbContext {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string stringConnection = ConfigurationManager.ConnectionStrings["dbAvalANConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
