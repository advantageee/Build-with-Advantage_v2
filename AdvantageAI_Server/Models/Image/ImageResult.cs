using System;

namespace AdvantageAIWeb.Models.Image
{
    /// <summary>
    /// Model representing the result of an image generation request.
    /// </summary>
    public class ImageResult
    {
        /// <summary>
        /// Gets the URL of the generated image.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets the revised prompt used for generating the image.
        /// </summary>
        public string RevisedPrompt { get; private set; }

        /// <summary>
        /// Gets the image URL (possibly different from the generated one).
        /// </summary>
        public string ImageUrl { get; private set; }

        /// <summary>
        /// Base64 encoded data of the image.
        /// </summary>
        private string Base64Data { get; set; }

        public ImageResult(string url, string revisedPrompt, string imageUrl = null, string base64Data = null)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Url cannot be null or empty.", nameof(url));
            }

            Url = url;
            RevisedPrompt = revisedPrompt?.Trim();
            ImageUrl = imageUrl?.Trim();
            Base64Data = base64Data?.Trim();
        }

        /// <summary>
        /// Converts Base64Data to a byte array.
        /// </summary>
        /// <returns>Byte array of the image data, or null if Base64Data is empty.</returns>
        public byte[] GetBytesFromBase64()
        {
            if (string.IsNullOrWhiteSpace(Base64Data))
            {
                return null;
            }

            try
            {
                return Convert.FromBase64String(Base64Data);
            }
            catch (FormatException)
            {
                throw new InvalidOperationException("Base64Data is not a valid Base64 string.");
            }
        }

        /// <summary>
        /// Saves the image from Base64Data to a file.
        /// </summary>
        /// <param name="filename">Optional filename; generates one if null.</param>
        /// <returns>True if successful; otherwise, false.</returns>
        public bool SaveFileFromBase64(string filename = null)
        {
            var bytes = GetBytesFromBase64();
            if (bytes == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = $"image_{Guid.NewGuid()}.png";
            }

            try
            {
                System.IO.File.WriteAllBytes(filename, bytes);
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception if a logging system is available
                Console.WriteLine($"Failed to save file: {ex.Message}");
                return false;
            }
        }

        public override string ToString()
        {
            return $"ImageResult: Url='{Url}', RevisedPrompt='{RevisedPrompt}', ImageUrl='{ImageUrl}'";
        }

        public static implicit operator string(ImageResult v)
        {
            throw new NotImplementedException();
        }
    }
}
