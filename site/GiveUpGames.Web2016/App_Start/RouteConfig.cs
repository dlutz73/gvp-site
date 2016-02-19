using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GiveUpGames.Web2016
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            GameRoute(routes, "AlphaChimp");
            GameRoute(routes, "ElfWhoKilledChristmas");
            GameRoute(routes, "ElfWhoKilledChristmas", "ChristmasGame");
            GameRoute(routes, "HomelessGuy");
            HomeRoute(routes, "Studio");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public static void GameRoute(RouteCollection routes, string gameActionName)
        {
            GameRoute(routes, gameActionName, gameActionName);
        }
        public static void GameRoute(RouteCollection routes, string gameActionName, string url)
        {
            routes.MapRoute(
                name: url,
                url: url,
                defaults: new { controller = "Game", action = "GameView", name = gameActionName }
            );
        }
        public static void HomeRoute(RouteCollection routes, string homeActionName)
        {
            routes.MapRoute(
                name: homeActionName,
                url: homeActionName,
                defaults: new { controller = "Home", action = homeActionName }
            );
        }
    }
}
