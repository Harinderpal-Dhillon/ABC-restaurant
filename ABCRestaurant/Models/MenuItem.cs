using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCRestaurant.Models
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public MenuCategory Category { get; set; }
        public double Price { get; set; }
        public double Calories { get; set; }

    }
}