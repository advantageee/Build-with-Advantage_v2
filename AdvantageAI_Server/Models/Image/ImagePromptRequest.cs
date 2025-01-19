using System;

namespace AdvantageAIWeb.Models.Image
{
    /// <summary>
    /// Represents a request for generating an image based on a prompt.
    /// </summary>
    public class ImagePromptRequest
    {
        public string Prompt { get; private set; }
        public string Size { get; private set; } = "1024x1024"; // Default size
        public string ImageStyle { get; private set; } = "realistic"; // Default style
        public string ImageQuality { get; private set; } = "high"; // Default quality
        public string Description { get; internal set; }

        public ImagePromptRequest(string prompt, string size = "1024x1024", string imageStyle = "realistic", string imageQuality = "high")
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            Prompt = prompt.Trim();
            Size = string.IsNullOrWhiteSpace(size) ? "1024x1024" : size.Trim();
            ImageStyle = string.IsNullOrWhiteSpace(imageStyle) ? "realistic" : imageStyle.Trim();
            ImageQuality = string.IsNullOrWhiteSpace(imageQuality) ? "high" : imageQuality.Trim();
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Prompt))
            {
                throw new InvalidOperationException("Prompt is required for an image generation request.");
            }

            if (string.IsNullOrWhiteSpace(Size))
            {
                throw new InvalidOperationException("Size is required for an image generation request.");
            }

            if (string.IsNullOrWhiteSpace(ImageStyle))
            {
                throw new InvalidOperationException("ImageStyle is required for an image generation request.");
            }

            if (string.IsNullOrWhiteSpace(ImageQuality))
            {
                throw new InvalidOperationException("ImageQuality is required for an image generation request.");
            }
        }

        public override string ToString()
        {
            return $"ImagePromptRequest: Prompt='{Prompt}', Size='{Size}', Style='{ImageStyle}', Quality='{ImageQuality}'";
        }
    }
}
