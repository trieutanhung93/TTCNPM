using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BKFoodCourt.Models
{
    public class ListOrder
    {
        Dictionary<Food, int> cart;

        public ListOrder()
        {
            Dictionary<Food, int> cart = new Dictionary<Food, int>();
        }

        public void AddItem(Food food)
        {
            if (cart.ContainsKey(food))
            {
                cart[food]++;
            }
            else
            {
                cart.Add(food, 1);
            }
        }

    }
}