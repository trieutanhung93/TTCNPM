using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using BKFoodCourt.Code;
using BKFoodCourt.Models;

namespace BKFoodCourt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]

        public ActionResult Index()
        {
            LoginSignUpModel.State = false;
            return View();
        }

        [HttpPost]

        public ActionResult Index(LoginSignUpModel model)
        {
            var result = new AccountModel().Login(model.Email, model.PassWord);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { Email = model.Email });
                LoginSignUpModel.State = true;
                loadData(model);
                LoginSignUpModel.typeAccount = account.TypeAccount;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                LoginSignUpModel.State = false;
            }
            return View(model);
        }
        private Account account;

        private DataTable dataTable = new DataTable();

        private void loadData(LoginSignUpModel model)
        {
            string connString = @"Data Source=DESKTOP-C8J1S1O\SQLEXPRESS;Initial Catalog=BKFOODCOURT;Integrated Security=True";
            string query = "select * from Account where Email = @Email";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@Email", model.Email);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            try
            {
                foreach (var row in dataTable.AsEnumerable())
                {
                    Account obj = new Account();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    account = obj;
                }
            }
            catch
            {
            }
        }
    }
}