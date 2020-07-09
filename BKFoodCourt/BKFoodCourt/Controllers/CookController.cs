using BKFoodCourt.Common;
using BKFoodCourt.DatabaseAccess.Dao;
using BKFoodCourt.DatabaseAccess.EF;
using BKFoodCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKFoodCourt.Controllers
{
    public class CookController : Controller
    {
        // GET: Cook
        private bool check()
        {
            LoginModel login = Session[CommonConstant.USER_SESSION] as LoginModel;
            if (login == null || login.typeAcc != 2)
            {
                return false;
            }
            return true;
        }

        public ActionResult Index()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult OrderList()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            var dao = new OrderDao();
            List<ListOrderModel> res = new List<ListOrderModel>();
            List<DonHang> listOrder = new List<DonHang>();
            listOrder = dao.getOrderList();
            foreach(var item in listOrder)
            {
                ListOrderModel order = new ListOrderModel();
                order.ID = item.ID;
                order.OrderCode = item.OrderCode;
                order.CustomerID = item.CustomerID;
                order.Price = item.Price;
                order.Timer = item.Timer;
                order.State = 0;
                List<OrderDetail> tmp = dao.getInfoOrder(item.ID);
                foreach(var i in tmp)
                {
                    order.list.Add(i.FoodID, i.Quantily);
                }
                res.Add(order);
            }
            return View(res);
        }

        public ActionResult CookInfo()
        {
            if (!check())
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }


        public ActionResult Cancel(int ID)
        {
            var dao = new OrderDao();
            DonHang item = dao.getOrder(ID);
            item.State = 2;
            dao.UpdateOrder(item);
            return RedirectToAction("OrderList", "Cook");
        }
        
        public ActionResult Process(int ID)
        {
            var dao = new OrderDao();
            List<OrderDetail> res = dao.getInfoOrder(ID);
            return View(res);
        }

        public ActionResult Finsh(int ID)
        {
            var dao = new OrderDao();
            DonHang item = dao.getOrder(ID);
            item.State = 1;
            dao.UpdateOrder(item);
            return RedirectToAction("OrderList", "Cook");
        }
    }
}