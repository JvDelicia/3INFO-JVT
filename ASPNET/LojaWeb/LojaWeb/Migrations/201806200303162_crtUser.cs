namespace LojaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crtUser : DbMigration
    {
		public override void Up() {
			CreateTable(
				"dbo.ProdCategories",
				c => new {
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(unicode: false),
					Description = c.String(unicode: false),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Products",
				c => new {
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(unicode: false),
					Description = c.String(unicode: false),
					Price = c.Single(nullable: false),
					Quantity = c.Int(nullable: false),
					CategoryId = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.ProdCategories", t => t.CategoryId, cascadeDelete: true)
				.Index(t => t.CategoryId);

			CreateTable(
				"dbo.Users",
				c => new {
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(unicode: false),
					Pass = c.String(unicode: false),
				})
				.PrimaryKey(t => t.Id);

		}

		public override void Down() {
			DropForeignKey("dbo.Products", "CategoryId", "dbo.ProdCategories");
			DropIndex("dbo.Products", new[] { "CategoryId" });
			DropTable("dbo.Users");
			DropTable("dbo.Products");
			DropTable("dbo.ProdCategories");
		}
    }
}
