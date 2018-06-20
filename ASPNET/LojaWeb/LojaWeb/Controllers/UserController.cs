using LojaWeb.DAO;
using LojaWeb.Models;
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

			return View();
		}

		public ActionResult Form() {

			return View();
		}

		public ActionResult Add(User u) {
			UserDAO udao = new UserDAO();
			udao.Insert(u);
			return View();
		}
	}
}