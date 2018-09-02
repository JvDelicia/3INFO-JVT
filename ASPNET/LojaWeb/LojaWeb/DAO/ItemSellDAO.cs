using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
	public class ItemSellDAO {
		private EntityContext context;

		public ItemSellDAO() {
			context = new EntityContext();
		}

		public IList<ItemSell> ItemSellList() {
			return context.ItemSells.ToList();
		}

		public ItemSell FindById(int id) {
			return context.ItemSells.FirstOrDefault(u => u.Id == id);
		}

		public void Insert(ItemSell isell) {
			context.ItemSells.Add(isell);
			context.SaveChanges();
		}

		public void Remove(ItemSell isell) {
			context.ItemSells.Remove(isell);
			context.SaveChanges();
		}

		public void Update() {
			context.SaveChanges();
		}
	}
}