using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Options = new List<string>()
                {
                "Buy a Drink",
                "View Purchased Drinks",
            };
            return View();
        }


    }
}