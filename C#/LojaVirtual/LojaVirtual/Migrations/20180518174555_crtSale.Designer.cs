using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using LojaVirtual;

namespace LojaVirtual.Migrations
{
    [DbContext(typeof(EntitiesContext))]
    [Migration("20180518174555_crtSale")]
    partial class crtSale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaVirtual.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaVirtual.Entities.ProdSale", b =>
                {
                    b.Property<int>("SaleId");

                    b.Property<int>("ProdID");

                    b.Property<int?>("ProductsId");

                    b.HasKey("SaleId", "ProdID");
                });

            modelBuilder.Entity("LojaVirtual.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaVirtual.Entities.Sale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("LojaVirtual.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Pass");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("LojaVirtual.Entities.ProdSale", b =>
                {
                    b.HasOne("LojaVirtual.Entities.Product")
                        .WithMany()
                        .HasForeignKey("ProductsId");

                    b.HasOne("LojaVirtual.Entities.Sale")
                        .WithMany()
                        .HasForeignKey("SaleId");
                });

            modelBuilder.Entity("LojaVirtual.Entities.Product", b =>
                {
                    b.HasOne("LojaVirtual.Entities.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("LojaVirtual.Entities.Sale", b =>
                {
                    b.HasOne("LojaVirtual.Entities.User")
                        .WithMany()
                        .HasForeignKey("ClientID");
                });
        }
    }
}
