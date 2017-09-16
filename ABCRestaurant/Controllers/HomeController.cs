using ABCRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCRestaurant.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
           Repository rep = new Repository();
            List<MenuItem> MList = rep.GetMenuItems();
             return View(MList);   
        }
        public ViewResult Survey()
        {
            Repository rep = new Repository();
            List<MenuItem> MList = rep.GetMenuItems();
            List<string> MenuList = new List<string>();
            MenuList.Add("");  // so that first time list shows blank
            foreach (MenuItem mi in MList)
                MenuList.Add(mi.ItemName);
            SurveyResponse sr = new SurveyResponse();
            sr.MenuItemList = MenuList;
            return View(sr);

        }
        [HttpPost]
        public ViewResult Survey(SurveyResponse sr)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Reply = "Thank you for submitting the survey. A 20% off coupon has been emailed to " + sr.Email;
                //return View(sr);  // will send the survey view back to browser
                return View("Thankyou", sr);
            }
            else
            {
                Repository rep = new Repository();
                List<MenuItem> MList = rep.GetMenuItems();
                List<string> MenuList = new List<string>();
                MenuList.Add("");  // so that first time list shows blank
                foreach (MenuItem mi in MList)
                    MenuList.Add(mi.ItemName);
                sr.MenuItemList = MenuList;
                return View(sr);
            }

        }
    }
}
