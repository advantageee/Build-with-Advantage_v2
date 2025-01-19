using System;
using System.ComponentModel.DataAnnotations;

namespace AdvantageAIWeb.ViewModels
{
    /// <summary>
    /// ViewModel for handling image generation prompts.
    /// </summary>
    public class ImagePromptViewModel
    {
        [Required(ErrorMessage = "Prompt is required.")]
        public string Prompt { get; set; }

        public string Size { get; set; } = "1024x1024";
        public string ImageStyle { get; set; } = "vivid";
        public string ImageQuality { get; set; } = "standard";

        public string GeneratedImageUrl { get; private set; }

        public void SetGeneratedImageUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Generated image URL cannot be null or empty.", nameof(url));
            }

            GeneratedImageUrl = url;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Prompt))
            {
                throw new InvalidOperationException("Prompt is required for image generation.");
            }

            if (string.IsNullOrWhiteSpace(Size))
            {
                throw new InvalidOperationException("Size is required for image generation.");
            }

            if (string.IsNullOrWhiteSpace(ImageStyle))
            {
                throw new InvalidOperationException("ImageStyle is required for image generation.");
            }

            if (string.IsNullOrWhiteSpace(ImageQuality))
            {
                throw new InvalidOperationException("ImageQuality is required for image generation.");
            }
        }

        public void Reset()
        {
            Prompt = string.Empty;
            GeneratedImageUrl = null;
        }

        public override string ToString()
        {
            return $"ImagePromptViewModel: Prompt='{Prompt}', Size='{Size}', Style='{ImageStyle}', Quality='{ImageQuality}', GeneratedUrl='{GeneratedImageUrl}'";
        }
    }
}
