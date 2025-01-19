using System.IO;
using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Interface for vision-related operations such as image analysis and caption generation.
    /// </summary>
    public interface IVisionService
    {
        /// <summary>
        /// Analyzes an image and returns its metadata or analysis result.
        /// </summary>
        /// <param name="imageUrl">The URL of the image to analyze.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the analysis result as a strongly typed object.
        /// </returns>
        Task<ImageAnalysisResult> AnalyzeImageAsync(string imageUrl);

        /// <summary>
        /// Generates a caption for the provided image file.
        /// </summary>
        /// <param name="filePath">The file path of the image to generate a caption for.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the generated caption.
        /// </returns>
        Task<string> GenerateCaptionAsync(string filePath);
        Task<string> GenerateCaptionAsync(Stream stream);

        /// <summary>
        /// Generates an image based on the provided prompt and deployment ID.
        /// </summary>
        /// <param name="prompt">The textual prompt for generating the image.</param>
        /// <param name="deploymentId">The deployment ID to use for the image generation model.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the URL of the generated image.
        /// </returns>
        Task<string> GenerateImageAsync(string prompt, string deploymentId);

        /// <summary>
        /// Generates a caption for an image specified by its URL.
        /// </summary>
        /// <param name="imageUrl">The URL of the image to generate a caption for.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the generated caption.
        /// </returns>
        Task<string> GenerateImageCaptionAsync(string imageUrl);

        /// <summary>
        /// Retrieves a description of the image from its byte array representation.
        /// </summary>
        /// <param name="image">The byte array representing the image.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the image description.
        /// </returns>
        Task<string> GetImageDescriptionAsync(byte[] image);
    }

    /// <summary>
    /// Represents the result of an image analysis operation.
    /// </summary>
    public class ImageAnalysisResult
    {
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public string[] Categories { get; internal set; }
    }
}
