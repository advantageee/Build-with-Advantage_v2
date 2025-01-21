using System.Threading.Tasks;
using AdvantageAIWeb.Models.Image;

namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Interface for DALL-E image generation service.
    /// </summary>
    public interface IDalleService
    {
        Task<ImageResult> GenerateImageAsync(ImagePromptRequest request);
        Task<string> GenerateImageAsync(string prompt, string size);
        Task<string> GenerateImageAsync(string prompt, string size, string style);
    }
}
