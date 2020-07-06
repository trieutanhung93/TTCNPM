using FoodCourt.Common;
using FoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCourt.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc!=1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult Report()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult UpdateMenu()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult Statistic()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult AdminInfo()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult CreateAccount()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 1)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}