using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCourt.Controllers
{
    public class CookController : Controller
    {
        // GET: Cook
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderList()
        {
            return View();
        }
        public ActionResult CookInfo()
        {
            return View();
        }
    }
}