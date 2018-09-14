namespace LojaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixer : DbMigration {
        public override void Up() {
            AddColumn("dbo.User", "Phone", c => c.String(unicode: false));
            AddColumn("dbo.User", "Born", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.User", "Email", c => c.String(unicode: false));
        }
        
        public override void Down() {
            DropColumn("dbo.User", "Email");
            DropColumn("dbo.User", "Born");
            DropColumn("dbo.User", "Phone");
        }
    }
}
