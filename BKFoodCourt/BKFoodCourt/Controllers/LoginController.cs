using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BKFoodCourt.Code;
using BKFoodCourt.Models;

namespace BKFoodCourt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]

        public ActionResult Index()
        {
            LoginSignUpModel.State = false;
            return View();
        }

        [HttpPost]

        public ActionResult Index(LoginSignUpModel model)
        {
            var result = new AccountModel().Login(model.Email, model.PassWord);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { Email = model.Email });
                LoginSignUpModel.State = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                LoginSignUpModel.State = false;
            }
            return View(model);
        }
    }
}