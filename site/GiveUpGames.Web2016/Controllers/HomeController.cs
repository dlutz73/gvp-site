using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveUpGames.Web2016.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToRoute("ElfWhoKilledChristmas");
        }

        [OutputCache(Duration = 90000, VaryByParam = "none")]
        public ActionResult Studio()
        {
            return View();
        }
    }
}