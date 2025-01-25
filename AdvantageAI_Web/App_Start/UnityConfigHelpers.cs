using AdvantageAI_Server.Services;
using AdvantageAI_Web;
using AdvantageAI_Web.App_Start;
using AdvantageAI_Web.Controllers;
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using Microsoft.Build.Framework;
using NLog;
using System.Web.Mvc;
using static AdvantageAI_Web.App_Start.AdvantageAIService;
using static Unity.Mvc5;

internal static class UnityConfigHelpers
{
    public static IUnityContainer Container { get; private set; }
    public static object LoggerFactory { get; private set; }

    public static void RegisterComponents(IUnityContainer container)
    {
        container = new UnityContainer();

        // Register dependencies here
        container.RegisterType<IAdvantageAIService, AdvantageAIService>();
        container.RegisterType<ITranslatorService, ITranslatorService>();
        container.RegisterType<IOpenAIService, OpenAIService>();
        container.RegisterType<IVisionService, IVisionService>();
        container.RegisterType<IDalleService, IDalleService>();
        container.RegisterType<ICodeGenerationService, CodeGenerationService>();
    }

      
    public static void RegisterTypes(IUnityContainer container)
    {
        // Register all required services and dependencies
        container.RegisterType<IAdvantageAIService, AdvantageAIService>();
        container.RegisterType<ITranslatorService, ITranslatorService>();
        container.RegisterType<IOpenAIService, OpenAIService>();
        container.RegisterType<IVisionService, IVisionService>();
        container.RegisterType<IDalleService, IDalleService>();
        container.RegisterType<ICodeGenerationService, CodeGenerationService>();
        container.RegisterInstance<BlobServiceClient>(new BlobServiceClient());

        // Register NLog logger
        container.RegisterInstance<NLog.ILogger>((NLog.ILogger)LogManager.GetCurrentClassLogger());
    }

    private class Logger<T>
    {
    }
}

internal interface ILoggerFactory
{
}
