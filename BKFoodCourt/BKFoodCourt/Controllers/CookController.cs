using BKFoodCourt.Common;
using BKFoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKFoodCourt.Controllers
{
    public class CookController : Controller
    {
        // GET: Cook
        public ActionResult Index()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 2)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult OrderList()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 2)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult CookInfo()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 2)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}