using System.Linq;
using System.Web.Http;
using Unity.Mvc5;
using AdvantageAI_Server;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AdvantageAI_Server.UnityWebApiActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(AdvantageAI_Server.UnityWebApiActivator), "Shutdown")]

namespace AdvantageAI_Web
{
    public static class UnityWebApiActivator
    {
        /// <summary>Integrates Unity when the application starts.</summary>
        public static void Start()
        {
            var resolver = new UnityDependencyResolver(UnityConfig.Container);
            GlobalConfiguration.Configuration.DependencyResolver = (System.Web.Http.Dependencies.IDependencyResolver)resolver;
        }

        /// <summary>Disposes the Unity container when the application is shut down.</summary>
        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }
    }
}