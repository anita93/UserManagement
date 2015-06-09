using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult Login(User U)
        {
           UserManagementContext DE = new UserManagementContext();
            var count = DE.Users.Where(x => x.UserName == U.UserName && x.Password == U.Password).Count();
            if (count == 0)
            {
                ViewBag.Msg = "Invalid User";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(U.UserName, false);
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}