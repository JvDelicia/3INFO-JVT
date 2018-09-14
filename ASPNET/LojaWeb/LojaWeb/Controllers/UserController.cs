using LojaWeb.DAO;
using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers {
    public class UserController : Controller {
		public object UserDao { get; private set; }

		// GET: User
		public ActionResult Index() {
            UserDAO udao = new UserDAO();
            IList<User> users = udao.UserList();
            ViewBag.Users = users;
            return View();
		}

		public ActionResult Form() {
			return View();
		}

		public ActionResult Add(User u) {
			UserDAO udao = new UserDAO();
			udao.Insert(u);
            return RedirectToAction("Index");
        }

        public ActionResult FormUp(string id) {
            UserDAO udao = new UserDAO();
            User user = udao.FindById(Convert.ToInt32(id));
            ViewBag.UserId = user;
            return View();
        }

		[HttpPostAttribute]
        public ActionResult Update(User u) {
            UserDAO udao = new UserDAO();
            User user = udao.FindById(Convert.ToInt32(u.Id));
            user.Name = u.Name;
            user.Pass = u.Pass;
            user.Phone = u.Phone;
            user.Born = u.Born;
            user.Email = u.Email;
            udao.Update();
            return RedirectToAction("Index");
        }

        [HttpPostAttribute]
        public ActionResult Remove(string id) {
            UserDAO udao = new UserDAO();
            User u = udao.FindById(Convert.ToInt32(id));
            udao.Remove(u);
            return RedirectToAction("Index");
        }
    }
}