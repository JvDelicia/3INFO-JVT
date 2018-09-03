namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF = c.Int(nullable: false),
                        Nome = c.String(nullable: false, unicode: false),
                        Endereco = c.String(nullable: false, unicode: false),
                        NumTel = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Login = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        Senha = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        Endereco = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        NumTel = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Descricao = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Preco = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Fabricante = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProdutoVenda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Double(nullable: false),
                        VendaId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Venda", t => t.VendaId, cascadeDelete: true)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecoTotal = c.Double(nullable: false),
                        Data = c.DateTime(nullable: false, precision: 0),
                        ClienteId = c.Int(nullable: false),
                        FuncionarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Venda");
            DropForeignKey("dbo.Venda", "FuncionarioId", "dbo.Funcionario");
            DropForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.ProdutoVenda", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.Venda", new[] { "FuncionarioId" });
            DropIndex("dbo.Venda", new[] { "ClienteId" });
            DropIndex("dbo.ProdutoVenda", new[] { "ProdutoId" });
            DropIndex("dbo.ProdutoVenda", new[] { "VendaId" });
            DropTable("dbo.Venda");
            DropTable("dbo.ProdutoVenda");
            DropTable("dbo.Produto");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Cliente");
        }
    }
}
