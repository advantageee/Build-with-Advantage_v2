using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using AdvantageAIWeb.Services.Interfaces;
using AdvantageAIWeb.Services;
using AdvantageAI_Server.Services;
using AdvantageAI_Server.Models;
using NLog;

namespace AdvantageAI_Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static readonly Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        public static void RegisterTypes(IUnityContainer container)
        {
            // Register all required services and dependencies
            container.RegisterType<IAdvantageAIService, AdvantageAIService>();
            container.RegisterType<ITranslatorService, TranslatorService>();
            container.RegisterType<IOpenAIService, OpenAIService>();
            container.RegisterType<IVisionService, VisionService>();
            container.RegisterType<IDalleService, DalleService>();
            container.RegisterType<ICodeGenerationService, CodeGenerationService>();
            container.RegisterType<BlobServiceClient>();

            // Register NLog logger
            container.RegisterInstance<ILogger>(LogManager.GetCurrentClassLogger());
        }
    }
}
