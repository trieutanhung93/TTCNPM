using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BKFoodCourt.Models;
using PagedList;
using PagedList.Mvc;

namespace BKFoodCourt.Controllers
{
    public class MenuController : Controller
    {
        SearchMenu db = new SearchMenu();
        // GET: Menu
        public ActionResult Index(string searchName,int ? page)
        {
            return View(db.Foods.Where(x => x.Name.Contains(searchName) || searchName == null).ToList().ToPagedList(page ?? 1, 8));
        }

        public ActionResult AddFood(int ID)
        {
            CartModel.cart.Add(ID);
            return RedirectToAction("Index", "Cart");
        }
    }
}