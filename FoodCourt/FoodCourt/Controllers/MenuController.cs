using FoodCourt.DatabaseAccess.Dao;
using FoodCourt.DatabaseAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCourt.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index(string search)
        {
            var dao = new FoodDao();
            List<Food> foodList = dao.search(search);
            return View(foodList);
        }
    }
}