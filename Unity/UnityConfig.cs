using System;
using Unity;
using Unity.Lifetime;
using AdvantageAIWeb.Services.Interfaces;
using AdvantageAIWeb.Services;
using System.Threading.Tasks;

namespace AdvantageAIWeb
{
    public static class UnityConfig
    {
        private static readonly Lazy<Unity.IUnityContainer> container = new Lazy<Unity.IUnityContainer>(() =>
        {
            var container = new Unity.UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static Unity.IUnityContainer Container => container.Value;

        private static void RegisterTypes(Unity.IUnityContainer container)
        {
            // Core AI Services
            container.RegisterType<IAdvantageAIService, AdvantageAI_Web.App_Start.AdvantageAIService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IOpenAIService, AdvantageAI_Server.Services.OpenAIService>(new ContainerControlledLifetimeManager());

            // Translation and Vision Services (with corrected namespaces)
            container.RegisterType<ITranslatorService, TranslatorService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IVisionService, AdvantageAI_Server.Models.VisionService>(new ContainerControlledLifetimeManager());

            // Image and Code Generation Services
            container.RegisterType<IDalleService, DalleService>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICodeGenerationService, CodeGenerationService>(new ContainerControlledLifetimeManager());

            // Data Retrieval (fixing missing service reference)
            container.RegisterType<RetrievalIService, RetrievalIService>(new ContainerControlledLifetimeManager());
        }

        public static void RegisterComponents(Unity.IUnityContainer container)
        {
            RegisterTypes(container);
        }
    }
       }


