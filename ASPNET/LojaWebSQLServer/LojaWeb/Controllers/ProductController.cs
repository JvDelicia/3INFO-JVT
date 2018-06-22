using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductDAO pdao = new ProductDAO();
            IList<Product> prod = pdao.ProductList();
            ViewBag.Products = prod;
            ProdCategoryDAO cdao = new ProdCategoryDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categories = cat;
            return View();
        }
        
        public ActionResult frmAdd()
        {
            ProdCategoryDAO cdao = new ProdCategoryDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categories = cat;
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Adicionar(Product p)
        {
            ProductDAO pdao = new ProductDAO();
            pdao.Insert(p);
            return RedirectToAction("Index");
        }
    }
}