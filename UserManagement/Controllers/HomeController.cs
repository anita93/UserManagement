using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    public class HomeController : Controller
    {
        private UserManagementContext db = new UserManagementContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}

