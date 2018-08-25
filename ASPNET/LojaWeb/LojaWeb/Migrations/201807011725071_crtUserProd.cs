namespace LojaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crtUserProd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Product",
				c => new {
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(unicode: false),
					Description = c.String(unicode: false),
					Price = c.Single(nullable: false),
					Quantity = c.Int(nullable: false),
					CategoryId = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.ProdCategory", t => t.CategoryId, cascadeDelete: true);
                //.Index(t => t.CategoryId); //Sempre substiruir pelo comando comentado abaixo no fim do Up()
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Pass = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);

			Sql("CREATE index  `IX_CategoryId` on `Product` (`CategoryId` DESC)"); //Esse substitui para cada .Index; Para descobrir é só executar com -Verbose e tirar o 'using HASH'

        }
        
        public override void Down()
        {
            DropForeignKey("Product", "CategoryId", "ProdCategory");
            DropIndex("Product", new[] { "CategoryId" });
            DropTable("User");
            DropTable("Product");
            DropTable("ProdCategory");
        }
    }
}