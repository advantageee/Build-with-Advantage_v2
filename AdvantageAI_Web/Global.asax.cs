using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;
using Unity;
using System.Web.Optimization;
using AdvantageAI_Web.App_Start;
using NLog;

namespace AdvantageAI_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IUnityContainer container;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        protected void Application_Start()
        {
            try
            {
                Logger.Info("Application Starting...");
                container = new UnityContainer();
                UnityConfig.RegisterComponents(container);

                AreaRegistration.RegisterAllAreas();
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);

                Logger.Info("Application Started Successfully");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Startup Error");
                throw;
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Logger.Error(exception, "Application Error");
            try
            {
                if (HttpContext.Current?.Response != null)
                {
                    HttpContext.Current.Response.Clear();
                    Server.ClearError();
                    Response.Redirect("~/Error");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Failed to handle error");
            }
        }

        protected void Application_End()
        {
            container?.Dispose();
        }
    }
}
