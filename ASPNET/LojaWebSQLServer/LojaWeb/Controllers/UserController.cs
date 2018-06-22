using LojaWeb.Models;
using LojaWeb.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class UserController : Controller
    {
        public object UserDao { get; private set; }

        // GET: User
        public ActionResult Index() {
            UserDAO udao = new UserDAO();
            IList<User> users = udao.UserList();
            ViewBag.Users = users;
            return View();
        }

        public ActionResult frmAdd() {

            return View();
        }

        public ActionResult frmAttDel()
        {
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Adicionar(User u) {
            UserDAO udao = new UserDAO();
            udao.Insert(u);
            return RedirectToAction("Index");
        }

        [HttpPostAttribute]
        public ActionResult Alterar(string nome, string pass, string id) {
            UserDAO udao = new UserDAO();
            User user = udao.FindById(Convert.ToInt32(id));
            user.Name = nome;
            user.Pass = pass;
            udao.Update();
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Deletar(string id)
        {
            UserDAO udao = new UserDAO();
            User u = udao.FindById(Convert.ToInt32(id));
            udao.Remove(u);
            return View();
        }
    }
}