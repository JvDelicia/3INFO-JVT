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
        [Route("Product", Name = "ProdList")]
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
            if (p.CategoryId.Equals(1) && p.Price < 20000){
                ModelState.AddModelError("p.SUVPrice", "The SUV price must be higher than $20k");
            } if (ModelState.IsValid){
                pdao.Insert(p);
                return RedirectToAction("Index");
            } else {
                CatProdDAO cdao = new CatProdDAO();
                ViewBag.Categorys = cdao.CategoryList();
                ViewBag.Class = "alert alert-danger";
                return View("frmAdd");
            }
            
        }

        public ActionResult FormUp(string id) {
			ProductDAO pdao = new ProductDAO();
			CatProdDAO cdao = new CatProdDAO();
			IList<ProdCategory> cat = cdao.CategoryList();
			ViewBag.Categorys = cat;
			Product prod = pdao.FindById(Convert.ToInt32(id));
			ViewBag.ProdId = prod;
			ProdCategory catid = cdao.FindById(Convert.ToInt32(prod.CategoryId));
			ViewBag.CatId = catid;
			return View();
        }

        [HttpPostAttribute]
        public ActionResult Update(Product p) { //string id, string name, string description, float price, int quantity, int category
			ProductDAO pdao = new ProductDAO();
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categorys = cat;
            Product prod = pdao.FindById(Convert.ToInt32(p.Id));
			prod.Name = p.Name;
			prod.Description = p.Description;
            prod.CategoryId = p.CategoryId;
			prod.Price = p.Price;
            prod.Quantity = p.Quantity;
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

        public ActionResult Show(int Id) {
            ProductDAO pdao = new ProductDAO();
            Product p = pdao.FindById(Id);
            ViewBag.Prod = p;
            return View(p);
        }

        [Route("Product/{Id}", Name = "ProdDetails")]
        public ActionResult Details(int Id) {
            ProductDAO pdao = new ProductDAO();
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            Product p = pdao.FindById(Convert.ToInt32(Id));
            ProdCategory catid = cdao.FindById(Convert.ToInt32(p.CategoryId));
            ViewBag.CatId = catid;
            ViewBag.ProdId = p;
            return View();
        }
    }
}