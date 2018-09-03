using MySql.Data.Entity;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecommerce.Models {
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class EntityContext : DbContext {
		public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ProdutoVenda> ProdutoVenda { get; set; }

		public EntityContext() : base("DBCommerce") { }
		public EntityContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}