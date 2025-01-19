using AAdvantageAI_Server.Interfaces; // Typo in namespace?
using AdvantageAI.Services.Interfaces;
using AdvantageAI_Server.Models;
using AdvantageAI_Server.Services;
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using AvantageAI_Server.Controllers;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.WebApi;

namespace AdvantageAI_Web.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            var translatorApiKey = ConfigurationManager.AppSettings["TranslatorApiKey"];
            var translatorEndpoint = ConfigurationManager.AppSettings["TranslatorEndpoint"];
            var openAIApiKey = ConfigurationManager.AppSettings["AdvantageAIKey"];
            var openAIEndpoint = ConfigurationManager.AppSettings["AdvantageAIEndpoint"];
            var visionApiKey = ConfigurationManager.AppSettings["VisionApiKey"];
            var visionEndpoint = ConfigurationManager.AppSettings["VisionEndpoint"];
            var dalleApiKey = ConfigurationManager.AppSettings["DalleApiKey"];
            var dalleEndpoint = ConfigurationManager.AppSettings["DalleEndpointUrl"];
            var blobConnectionString = ConfigurationManager.AppSettings["BlobStorageConnectionString"];

            
            container.RegisterType<IAdvantageAIService, AdvantageAIService>();
            container.RegisterType<ITranslatorService, TranslatorService>();
            container.RegisterType<IOpenAIService, OpenAIService>();
            container.RegisterType<IVisionService, VisionService>();
            container.RegisterType<IDalleService, DalleService>();
            container.RegisterType<ICodeGenerationService, CodeGenerationService>();
            container.RegisterInstance(new BlobServiceClient(blobConnectionString));

            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            container.RegisterInstance<ILoggerFactory>(loggerFactory);
            container.RegisterType(typeof(ILogger<>), typeof(Logger<>));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}