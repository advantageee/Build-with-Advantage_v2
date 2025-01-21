using System.Web.Mvc;
using System.Web.Routing;
using NLog;

namespace AdvantageAI_Web.App_Start
{
    public class RouteConfig
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void RegisterRoutes(RouteCollection routes)
        {
            Logger.Info("Registering routes...");

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            Logger.Info("Routes registered successfully.");
        }
    }
}
