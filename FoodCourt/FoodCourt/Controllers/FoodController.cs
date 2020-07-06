using FoodCourt.DatabaseAccess.Dao;
using FoodCourt.DatabaseAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCourt.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Detail(int foodId)
        {
            var dao = new FoodDao();
            Food food = dao.getById(foodId);
            return View(food);
        }
    }
}