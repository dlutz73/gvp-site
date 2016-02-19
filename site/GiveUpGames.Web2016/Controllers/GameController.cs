using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveUpGames.Web2016.Controllers
{
    public class GameController : Controller
    {
        [OutputCache(Duration = 90000, VaryByParam = "name")]
        public ActionResult GameView(string name)
        {
            return View(name);
        }
    }
}