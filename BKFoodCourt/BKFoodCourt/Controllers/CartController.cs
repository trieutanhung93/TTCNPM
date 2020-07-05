using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BKFoodCourt.Models;

namespace BKFoodCourt.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
            //if (LoginSignUpModel.State == true)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Login");
            //}
        }
        public ActionResult Remove(int ID)
        {
            CartModel.cart.Remove(ID);
            return RedirectToAction("Index", "Cart");
        }
        public ActionResult changeQuantity(int id,int quantity)
        {
            CartModel.cart.changeQuantity(id, quantity);
            return RedirectToAction("Index", "Cart");
        }
    }
}