using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers {
    public class ProductController : Controller {
        // GET: Product
        public ActionResult Index() {
            ProductDAO pdao = new ProductDAO();
            IList<Product> prod = pdao.ProductList();
            ViewBag.Products = prod;
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categorys = cat;
            return View();
        }

        public ActionResult frmAdd() {
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categorys = cat;
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Add(Product p) {
            ProductDAO pdao = new ProductDAO();
            pdao.Insert(p);
            return RedirectToAction("Index");
        }

        public ActionResult FormUp(string id) {
			ProductDAO pdao = new ProductDAO();
			IList<Product> Products = pdao.ProductList();
			Product prod = pdao.FindById(Convert.ToInt32(id));
			ViewBag.ProdId = prod;
			return View();
        }

        [HttpPostAttribute]
        public ActionResult Update(string id, string name, string description, int category, float price, int quantity) {
            ProductDAO pdao = new ProductDAO();
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categorys = cat;
            Product prod = pdao.FindById(Convert.ToInt32(id));
            prod.Name = name;
            prod.Description = description;
            prod.CategoryId = category;
            prod.Price = price;
            prod.Quantity = quantity;
            pdao.Update();
			return RedirectToAction("Index");
		}

        [HttpPostAttribute]
        public ActionResult Remove(string id) {
            ProductDAO pdao = new ProductDAO();
			Product p = pdao.FindById(Convert.ToInt32(id));
            pdao.Remove(p);
			return RedirectToAction("Index");
		}
    }
}