public static void RegisterTypes(IUnityContainer container)
{
    container.RegisterType<IOpenAIService, OpenAIService>();
    // ...existing code...
}
