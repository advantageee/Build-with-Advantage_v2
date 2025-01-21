using System.Web.Mvc;
using System.Web.Routing;

namespace AdvantageAI_Web.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Root",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Translator",
                url: "Translator/{action}/{id}",
                defaults: new { controller = "Translator", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Vision",
                url: "Vision/{action}/{id}",
                defaults: new { controller = "Vision", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
