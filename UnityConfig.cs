using AdvantageAI.Controllers;
using AdvantageAI.Services; // Server services
using AdvantageAI.Services.Interfaces; // Service interfaces
using AdvantageAIWeb.Services;
using Azure.Storage.Blobs; // For BlobServiceClient
using Microsoft.Extensions.Logging; // For logging
using System;
using System.Configuration;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.WebApi;
using Unity.Injection;
using Unity.Mvc5;

namespace AdvantageAIWeb.App_Start
{
    public static class UnityConfig
    {
        private static readonly ILogger Logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("UnityConfig");

        public static void RegisterComponents(IUnityContainer container)
        {
            try
            {
                // Retrieve settings from appSettings
                var translatorApiKey = ConfigurationManager.AppSettings["TranslatorApiKey"];
                var translatorEndpoint = ConfigurationManager.AppSettings["TranslatorEndpoint"];
                var openAIApiKey = ConfigurationManager.AppSettings["AdvantageAIKey"];
                var openAIEndpoint = ConfigurationManager.AppSettings["AdvantageAIEndpoint"];
                var visionApiKey = ConfigurationManager.AppSettings["VisionApiKey"];
                var visionEndpoint = ConfigurationManager.AppSettings["VisionEndpoint"];
                var dalleApiKey = ConfigurationManager.AppSettings["DalleApiKey"];
                var dalleEndpoint = ConfigurationManager.AppSettings["DalleEndpointUrl"];
                var blobConnectionString = ConfigurationManager.AppSettings["BlobStorageConnectionString"]
                    ?? throw new ConfigurationErrorsException("BlobStorageConnectionString is missing in appSettings.");

                // Register services with their respective interfaces
                container.RegisterType<ITranslatorService, TranslatorService>(
                    new InjectionConstructor(translatorApiKey, translatorEndpoint));

                container.RegisterType<IOpenAIService, OpenAIService>(
                    new InjectionConstructor(openAIApiKey, openAIEndpoint));

                container.RegisterType<IVisionService, VisionService>(
                    new InjectionConstructor(visionApiKey, visionEndpoint));

                container.RegisterType<IDalleService, DalleService>(
                new InjectionConstructor(dalleApiKey, dalleEndpoint));

                container.RegisterType<ICodeGenerationService, CodeGenerationService>();

                // Register Blob Storage Client as a singleton instance
                var blobServiceClient = new BlobServiceClient(blobConnectionString);
                container.RegisterInstance(blobServiceClient);

                // Set Dependency Resolver
                DependencyResolver.SetResolver(new UnityDependencyResolver(container));

                Logger.LogInformation("Unity container configured successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError("Critical error during Unity container registration: {Error}", ex.Message);
                throw;
            }
        }
    }
}
