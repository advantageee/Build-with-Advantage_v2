using AdvantageAI_Server.Models;
using AdvantageAI_Server.Services;
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.WebApi;
using Unity.Injection;

namespace AdvantageAI_Web.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            // Your existing configuration code stays the same
            var translatorApiKey = ConfigurationManager.AppSettings["TranslatorApiKey"];
            var translatorEndpoint = ConfigurationManager.AppSettings["TranslatorEndpoint"];
            var openAIApiKey = ConfigurationManager.AppSettings["AdvantageAIKey"];
            var openAIEndpoint = ConfigurationManager.AppSettings["AdvantageAIEndpoint"];
            var visionApiKey = ConfigurationManager.AppSettings["VisionApiKey"];
            var visionEndpoint = ConfigurationManager.AppSettings["VisionEndpoint"];
            var dalleApiKey = ConfigurationManager.AppSettings["DalleApiKey"];
            var dalleEndpoint = ConfigurationManager.AppSettings["DalleEndpointUrl"];
            var blobConnectionString = ConfigurationManager.AppSettings["BlobStorageConnectionString"];

            // Register your services
            container.RegisterType<IAdvantageAIService, IAdvantageAIService>();
            container.RegisterType<ITranslatorService, TranslatorService>(new InjectionConstructor(translatorApiKey, translatorEndpoint));
            container.RegisterType<IOpenAIService, OpenAIService>(new InjectionConstructor(openAIApiKey, openAIEndpoint));
            container.RegisterType<IVisionService, VisionService>(new InjectionConstructor(visionApiKey, visionEndpoint));
            container.RegisterType<IDalleService, DalleService>(new InjectionConstructor(dalleApiKey, dalleEndpoint));
            container.RegisterType<ICodeGenerationService, CodeGenerationService>();

            if (!string.IsNullOrEmpty(blobConnectionString))
            {
                container.RegisterInstance(new AvantageAI_Server.Controllers.BlobServiceClient(blobConnectionString));
            }

            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            container.RegisterInstance<ILoggerFactory>(loggerFactory);
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}