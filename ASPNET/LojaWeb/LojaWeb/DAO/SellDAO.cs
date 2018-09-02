using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
	public class SellDAO {
		private EntityContext context;

		public SellDAO() {
			context = new EntityContext();
		}

		public IList<Sell> SellList() {
			return context.Sells.ToList();
		}

		public Sell FindById(int id) {
			return context.Sells.FirstOrDefault(u => u.Id == id);
		}

		public void Insert(Sell sell) {
			context.Sells.Add(sell);
			context.SaveChanges();
		}

		public void Remove(Sell sell) {
			context.Sells.Remove(sell);
			context.SaveChanges();
		}

		public void Update() {
			context.SaveChanges();
		}
	}
}