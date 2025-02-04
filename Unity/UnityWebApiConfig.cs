using System;
using Unity;
using static AdvantageAI_Web.UnityWebApiActivator;
using AdvantageAIWeb.Services.Interfaces;
using AdvantageAI_Server.UnityWebApiActivator;

namespace AdvantageAI_Server
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityWebApiConfig
    {
        #region Unity Container
        private static Lazy<AdvantageAI_Server.UnityWebApiActivator.IUnityContainer> container =
          new Lazy<AdvantageAI_Server.UnityWebApiActivator.IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return (UnityWebApiActivator.IUnityContainer)container;
          });

        private static void RegisterTypes(UnityContainer container)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static AdvantageAI_Server.UnityWebApiActivator.IUnityContainer Container => container.Value;

        public static void RegisterComponents(AdvantageAI_Server.UnityWebApiActivator.IUnityContainer container)
        {
            // Correct interface usage
            AdvantageAI_Web.UnityConfig.RegisterComponents(AdvantageAI_Web.UnityConfig.Container);
        }
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(AdvantageAI_Server.UnityWebApiActivator.IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
        }

        private class UnityContainer : AdvantageAI_Web.UnityWebApiActivator.IUnityContainer
        {
        }
    }
}
