using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BKFoodCourt.Models;

namespace BKFoodCourt.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            LoginSignUpModel.State = false;
            return RedirectToAction("Index", "Home");
        }
    }
}