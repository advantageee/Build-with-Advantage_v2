namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Interface for image prompt request handling.
    /// </summary>
    public interface IImagePromptRequest
    {
        string Prompt { get; set; }
        string Size { get; set; }
        string ImageStyle { get; set; }
        string ImageQuality { get; set; }
    }
}
