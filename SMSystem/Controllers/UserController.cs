using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSystem.DBConnection;
using SMSystem.Models;
using SMSystem.ViewModel;
using SMSystem.ViewModel.UserViewModel;

namespace SMSystem.Controllers
{
    public class UserController : Controller
    {
        private SM_System _db;

        public UserController()
        {
            _db= new SM_System();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

        public ActionResult Login()
        {  
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = null;

                if (_db.Users.Any())
                {
                    user = _db.Users.FirstOrDefault(o => o.UserName.Equals(loginViewModel.UserName) && o.PasswordHash.Equals(loginViewModel.PasswordHash));
                }

                if (user == null)
                {
                    //ModelState.AddModelError("", "Wrong username and password");
                    TempData["LOGIN_FAIL"] = "Wrong username and password";
                }
                else
                {
                    if (user.UserType.Equals(UserType.Admin))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        public ActionResult FogetPassword()
        {
            return View();
        }

        public ActionResult RegisterNow()
        {
            return View();
        }


    }
}
