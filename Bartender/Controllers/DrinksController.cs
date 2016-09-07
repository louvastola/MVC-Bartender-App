using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bartender.Models;

namespace Bartender.Controllers
{
    public class DrinksController : Controller
    {
        // GET: Drinks
        public ActionResult Random()
        {
            var drink = new Drink() {Name = "Manhatten"};

            return View(drink);
        }
    }
}