using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers {
    public class SellController : Controller {
        // GET: Sell
        public ActionResult Index() {
            return View();
        }

		public ActionResult AddToCart(int id) {
			SellDAO sdao = new SellDAO();
			ItemSellDAO idao = new ItemSellDAO();

			Sell cart = Session["Cart"] != null ? (Sell)Session["Cart"] : new Sell();

			var d = sdao.FindById(id);
			if ( d != null ) {
				var itemSell = new ItemSell();
				itemSell.Sell = d;
				itemSell.Quantity = 1;

				if (cart.ItemProd.FirstOrDefault(x => x.SellId == d.Id) != null) {
					cart.ItemProd.FirstOrDefault(x => x.SellId == d.Id).Quantity = +1;
				} else {
					cart.ItemProd.Add(itemSell);
				}

				cart.TotalPrice = cart.ItemProd.Select(i => i.Sell).Sum(a => a.TotalPrice);

				Session["Cart"] = cart;
			}
			return View();
		}
	}
}