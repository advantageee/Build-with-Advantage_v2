using AdvantageAI_Web.App_Start;
using System.Web.Http;
using Unity.AspNet.WebApi;
using Unity;

namespace AdvantageAI_Web
{
    public static class UnityWebApiActivator
    {
        private static IUnityContainer container;

        public static void Start()
        {
            container = new UnityContainer();
            UnityConfig.RegisterComponents(container);
            var resolver = new UnityDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        public static void Shutdown()
        {
            container?.Dispose();
        }
    }
}