using System;

using Unity;
using static AdvantageAI_Web.UnityWebApiActivator;

namespace AdvantageAI_Server
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<AdvantageAI_Web.UnityWebApiActivator.IUnityContainer> container =
          new Lazy<AdvantageAI_Web.UnityWebApiActivator.IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return (AdvantageAI_Web.UnityWebApiActivator.IUnityContainer)container;
          });

        private static void RegisterTypes(UnityContainer container)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static AdvantageAI_Web.UnityWebApiActivator.IUnityContainer Container => container.Value;
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
        public static void RegisterTypes(AdvantageAI_Web.UnityWebApiActivator.IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
        }

        internal static void RegisterComponents(AdvantageAI_Web.UnityWebApiActivator.IUnityContainer container)
        {
            throw new NotImplementedException();
        }
    }
}