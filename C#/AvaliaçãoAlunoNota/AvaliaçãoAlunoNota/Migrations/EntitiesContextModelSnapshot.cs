using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AvaliaçãoAlunoNota;

namespace AvaliaçãoAlunoNota.Migrations
{
    [DbContext(typeof(EntitiesContext))]
    partial class EntitiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvaliaçãoAlunoNota.Entidades.Aluno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AvaliaçãoAlunoNota.Entidades.Nota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlunosID");

                    b.Property<int>("IDALuno");

                    b.Property<string>("Nome");

                    b.Property<double>("Valor");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("AvaliaçãoAlunoNota.Entidades.Nota", b =>
                {
                    b.HasOne("AvaliaçãoAlunoNota.Entidades.Aluno")
                        .WithMany()
                        .HasForeignKey("AlunosID");
                });
        }
    }
}
