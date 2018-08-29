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

        [HttpPostAttribute]
        public ActionResult Remove(string id) {
            CatProdDAO cdao = new CatProdDAO();
            ProdCategory c = cdao.FindById(Convert.ToInt32(id));
            cdao.Remove(c);
            return RedirectToAction("Index");
        }

        public ActionResult FormUp(string id) {
            CatProdDAO cdao = new CatProdDAO();
            ProdCategory cat = cdao.FindById(Convert.ToInt32(id));
            ViewBag.CatId = cat;
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Update(ProdCategory c) {
            CatProdDAO cdao = new CatProdDAO();
            ProdCategory cat = cdao.FindById(Convert.ToInt32(c.Id));
            cat.Name = c.Name;
            cat.Description = c.Description;
            cdao.Update();
            return RedirectToAction("Index");
        }
    }
}