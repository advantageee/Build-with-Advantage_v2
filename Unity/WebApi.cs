using AdvantageAI_Server;
using AdvantageAI_Web;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using static AdvantageAI_Web.UnityWebApiActivator;
using AdvantageAIWeb.Services.Interfaces;
using System.Web.Http;

namespace Unity
{
    internal class WebApi
    {
        internal class UnityDependencyResolver : IDependencyResolver
        {
            private AdvantageAI_Web.IUnityContainer container;

            public UnityDependencyResolver(AdvantageAI_Server.UnityWebApiActivator.IUnityContainer container)
            {
                this.container = (AdvantageAI_Web.IUnityContainer)container;
            }

            public UnityDependencyResolver(AdvantageAI_Web.IUnityContainer container)
            {
                this.container = container;
            }

            public UnityDependencyResolver(AdvantageAI_Web.UnityWebApiActivator.IUnityContainer container1)
            {
            }

            public UnityDependencyResolver(IUnityContainer container1)
            {
                Container = container1;
            }

            public IUnityContainer Container { get; }

            public IDependencyScope BeginScope()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public object GetService(Type serviceType)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                throw new NotImplementedException();
            }
        }
    }
}

namespace AdvantageAI_Server.Unity
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}