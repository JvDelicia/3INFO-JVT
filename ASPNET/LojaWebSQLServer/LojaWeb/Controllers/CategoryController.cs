using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            ProdCategoryDAO cdao = new ProdCategoryDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categories = cat;
            return View();
        }

        public ActionResult frmAdd()
        {
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Adicionar(ProdCategory c)
        {
            ProdCategoryDAO cdao = new ProdCategoryDAO();
            cdao.Insert(c);
            return RedirectToAction("Index");
        }
    }
}