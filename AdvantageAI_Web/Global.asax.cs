using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;
using Unity;
using System.Web.Optimization;
using AdvantageAI_Web.App_Start;
using System.Web.Http;
using BuildwithAdvantageAI;

namespace AdvantageAI_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            try
            {
                Debug.WriteLine("Application Starting...");

                // Initialize Unity Container
                var container = new UnityContainer();
                UnityConfig.RegisterComponents(container);

                // Register all areas
                AreaRegistration.RegisterAllAreas();

                // Register Web API routes and config
                GlobalConfiguration.Configure(WebApiConfig.Register);

                // Register MVC components
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);

                // Set Unity as the dependency resolver for both MVC and Web API
                DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
                GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

                Debug.WriteLine("Application Started Successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Startup Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    Debug.WriteLine($"Stack Trace: {ex.InnerException.StackTrace}");
                }
                throw;
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            Debug.WriteLine($"Application Error: {exception?.Message}");

            try
            {
                if (HttpContext.Current?.Response != null && !HttpContext.Current.Response.IsRequestBeingRedirected)
                {
                    HttpContext.Current.Response.Clear();
                    Server.ClearError();

                    var httpException = exception as HttpException;
                    var routeData = new RouteData();
                    routeData.Values.Add("controller", "Error");
                    routeData.Values.Add("action", "Index");
                    routeData.Values.Add("exception", exception);

                    if (httpException != null)
                    {
                        Response.StatusCode = httpException.GetHttpCode();
                        routeData.Values.Add("statusCode", httpException.GetHttpCode());
                    }
                    else
                    {
                        Response.StatusCode = 500;
                        routeData.Values.Add("statusCode", 500);
                    }

                    IController controller = new AdvantageAI_Web.Controllers.ErrorController();
                    var rc = new RequestContext(new HttpContextWrapper(Context), routeData);
                    controller.Execute(rc);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error Handler Failed: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        protected void Application_End()
        {
            try
            {
                Debug.WriteLine("Application Ended - Resources Cleaned Up");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during application shutdown: {ex.Message}");
            }
        }
    }
}
