using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class MenuController : Controller
    {
       
        public ActionResult Details(int id)
        {
            Drinks DRINKS = new Drinks();
            Drink drink = Drinks.Drank.Single(dr => dr.DrinkId == id)
            

            };
            return View(drink);
        }
    }
}