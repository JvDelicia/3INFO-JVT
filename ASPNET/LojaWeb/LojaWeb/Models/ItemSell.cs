using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.Models {
	public class ItemSell {
		public int Id { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public Product Product { get; set; }
		public int ProductId { get; set; }
		public Sell Sell { get; set; }
		public int SellId { get; set; }
	}
}