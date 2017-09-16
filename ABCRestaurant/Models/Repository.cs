using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCRestaurant.Models
{
    public class Repository
    {
        public List<MenuItem> GetMenuItems()
        {
// obtain menu items from DB
List<MenuItem> MList = new List<MenuItem>();
MenuItem mn1 = new MenuItem { ItemName = "Ravioli", Category = MenuCategory.LUNCH, Price = 9.95, Calories = 495 };
            MList.Add(mn1);
MenuItem mn2 = new MenuItem { ItemName = "Eggplant Parmesan", Category = MenuCategory.LUNCH, Price = 11.95, Calories = 595 };
            MList.Add(mn2);
MenuItem mn3 = new MenuItem { ItemName = "Cheese Cake", Category = MenuCategory.DESSERT, Price = 5.95, Calories = 495 };
            MList.Add(mn3);
return MList;
        }

    }
}