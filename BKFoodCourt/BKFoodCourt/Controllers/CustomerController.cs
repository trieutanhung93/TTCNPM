using BKFoodCourt.Common;
using BKFoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKFoodCourt.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult Contact()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
        public ActionResult UserInfo()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }
    }
}