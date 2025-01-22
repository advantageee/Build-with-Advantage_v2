using AdvantageAI_Server.Models;
using AdvantageAI_Server.Services;
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AdvantageAI_Web
{
    public static class UnityConfig
    {
        public static IUnityContainer Container { get; private set; }

        public static void RegisterComponents(IUnityContainer container)
        {
            container = new UnityContainer();

            // Register dependencies here
            container.RegisterType<IAdvantageAIService, AdvantageAIService>();
            container.RegisterType<ITranslatorService, TranslatorService>();
            container.RegisterType<IOpenAIService, OpenAIService>();
            container.RegisterType<IVisionService, VisionService>();
            container.RegisterType<IDalleService, DalleService>();
            container.RegisterType<ICodeGenerationService, CodeGenerationService>();

            // Register logging
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            container.RegisterInstance<ILoggerFactory>(loggerFactory);
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            Container = container;
        }

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
