using System;
using AdvantageAI_Server.Interfaces;

namespace AdvantageAIWeb.Models.AI
{
    internal class ImagePromptRequest : AdvantageAIWeb.Services.Interfaces.IImagePromptRequest
    {
        public string Prompt { get; set; }
        public string Size { get; set; } = "1024x1024"; // Default to a standard size
        public string ImageQuality { get; set; } = "high"; // Default to high quality
        public string ImageStyle { get; set; } = "realistic"; // Default to realistic style
        public string Description { get; internal set; }

        public ImagePromptRequest(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            Prompt = prompt;
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

            if (string.IsNullOrWhiteSpace(ImageQuality))
            {
                throw new InvalidOperationException("ImageQuality is required for image generation.");
            }

            if (string.IsNullOrWhiteSpace(ImageStyle))
            {
                throw new InvalidOperationException("ImageStyle is required for image generation.");
            }
        }
    }
}
