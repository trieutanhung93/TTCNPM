using BKFoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKFoodCourt.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(LoginSignUpModel model)
        {
            SqlCommand cmd;
            SqlConnection con;
            SqlDataAdapter da;

            var result = new AccountModel().CheckAccount(model.Email);
            if (!result && ModelState.IsValid)
            {
                LoginSignUpModel.State = true;
                con = new SqlConnection(@"Data Source=DESKTOP-C8J1S1O\SQLEXPRESS;Initial Catalog=BKFOODCOURT;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                con.Open();
                cmd = new SqlCommand("INSERT INTO Account(Email,PassWord,Name) VALUES (@Email,@PassWord,@Name)", con);
                cmd.Parameters.Add("@Email", model.Email);
                cmd.Parameters.Add("@PassWord", model.PassWord);
                cmd.Parameters.Add("@Name", model.Name);
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email đã được sử dụng");
                LoginSignUpModel.State = false;
            }
            return View(model);
        }
    }
}