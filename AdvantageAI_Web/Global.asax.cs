using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;
using Unity;
using System.Web.Optimization;
using AdvantageAI_Web.App_Start;

namespace AdvantageAI_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IUnityContainer container;
        protected void Application_Start()
        {
            try
            {
                Debug.WriteLine("Application Starting...");
                container = new UnityContainer();
                UnityConfig.RegisterComponents(container);

                AreaRegistration.RegisterAllAreas();
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);

                Debug.WriteLine("Application Started Successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Startup Error: {ex.Message}");
                throw;
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Debug.WriteLine($"Application Error: {exception?.Message}");
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
                Debug.WriteLine("Failed to handle error: " + ex.Message);
            }
        }

        protected void Application_End()
        {
            container?.Dispose();
        }
    }
}
