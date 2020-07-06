using FoodCourt.DatabaseAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodCourt.Models
{
    public class CartModel
    {
        public Dictionary<Food,int> cart = null;
        public CartModel()
        {
            cart = new Dictionary<Food, int>();
        }
        public long tongTien { get; set; }
    }
}