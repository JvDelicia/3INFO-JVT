using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class CatProdController : Controller
    {
        // GET: Category
        public ActionResult Index() {
            CatProdDAO cdao = new CatProdDAO();
            IList<ProdCategory> cat = cdao.CategoryList();
            ViewBag.Categorys = cat;
            return View();
        }

        public ActionResult frmAdd() {
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Add(ProdCategory c) {
            CatProdDAO cdao = new CatProdDAO();
            cdao.Insert(c);
            return RedirectToAction("Index");
        }
    }
}