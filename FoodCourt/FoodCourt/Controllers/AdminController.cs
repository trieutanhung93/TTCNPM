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
            return View();
        }
        public ActionResult Report()
        {
            return View();
        }
        public ActionResult UpdateMenu()
        {
            return View();
        }
        public ActionResult Statistic()
        {
            return View();
        }
        public ActionResult AdminInfo()
        {
            return View();
        }
        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}