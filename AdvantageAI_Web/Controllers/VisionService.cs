using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic; // Add this
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using Logger = NLog.Logger;
// Remove incorrect using directive
// using System.Memory;

namespace AdvantageAI_Server.Models
{
    public class VisionService : IVisionService
    {
        private readonly string _visionApiKey;
        private readonly string _visionEndpoint;
        private readonly HttpClient _httpClient;
        private readonly Logger _logger;

        public VisionService(string apiKey, string endpoint)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey));
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentNullException(nameof(endpoint));

            _visionApiKey = apiKey;
            _visionEndpoint = endpoint;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("api-key", _visionApiKey);
            _logger = LogManager.GetCurrentClassLogger();
        }

        public async Task<ImageAnalysisResult> AnalyzeImageAsync(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Invalid image URL.", nameof(imageUrl));

            var requestBody = new
            {
                messages = new object[]
                {
                new
                {
                    role = "user",
                    content = new object[]
                    {
                        new { type = "text", text = "Analyze this image in detail." },
                        new { type = "image_url", url = imageUrl }
                    }
                }
                }
            };

            try
            {
                var response = await SendRequestAsync(requestBody);
                return new ImageAnalysisResult
                {
                    Description = response,
                    Tags = Array.Empty<string>()
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error analyzing image.");
                throw new InvalidOperationException("Image analysis failed.", ex);
            }
        }

        public async Task<string> GenerateCaptionAsync(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            using (var stream = File.OpenRead(filePath))
            {
                return await GenerateCaptionAsync(stream);
            }
        }

        public async Task<string> GenerateCaptionAsync(Stream stream)
        {
            if (stream == null || !stream.CanRead)
                throw new ArgumentException("Invalid stream", nameof(stream));

            try
            {
                using (var ms = new MemoryStream())
                {
                    await stream.CopyToAsync(ms);
                    var imageBytes = ms.ToArray();
                    var base64Image = Convert.ToBase64String(imageBytes);

                    var requestBody = new
                    {
                        messages = new object[]
                        {
                        new
                        {
                            role = "user",
                            content = new object[]
                            {
                                new { type = "text", text = "Generate a caption for this image." },
                                new { type = "image_url", url = $"data:image/jpeg;base64,{base64Image}" }
                            }
                        }
                        }
                    };

                    return await SendRequestAsync(requestBody);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating caption from stream.");
                throw new InvalidOperationException("Caption generation failed.", ex);
            }
        }

        public async Task<string> GenerateImageAsync(string prompt, string deploymentId)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                throw new ArgumentException("Prompt cannot be empty", nameof(prompt));

            var requestBody = new
            {
                model = deploymentId ?? "gpt-4-vision-preview",
                messages = new object[]
                {
                new
                {
                    role = "user",
                    content = new object[]
                    {
                        new { type = "text", text = prompt }
                    }
                }
                }
            };

            try
            {
                return await SendRequestAsync(requestBody);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating image.");
                throw new InvalidOperationException("Image generation failed.", ex);
            }
        }

        public async Task<string> GenerateImageCaptionAsync(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Invalid image URL.", nameof(imageUrl));

            var requestBody = new
            {
                messages = new object[]
                {
                new
                {
                    role = "user",
                    content = new object[]
                    {
                        new { type = "text", text = "Generate a caption for this image." },
                        new { type = "image_url", url = imageUrl }
                    }
                }
                }
            };

            try
            {
                return await SendRequestAsync(requestBody);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating image caption.");
                throw new InvalidOperationException("Image caption generation failed.", ex);
            }
        }

        public async Task<string> GetImageDescriptionAsync(byte[] image)
        {
            if (image == null || image.Length == 0)
                throw new ArgumentException("Image data cannot be null or empty.", nameof(image));

            var base64Image = Convert.ToBase64String(image);
            var requestBody = new
            {
                messages = new object[]
                {
                new
                {
                    role = "user",
                    content = new object[]
                    {
                        new { type = "text", text = "Describe this image in detail." },
                        new { type = "image_url", url = $"data:image/jpeg;base64,{base64Image}" }
                    }
                }
                }
            };

            try
            {
                return await SendRequestAsync(requestBody);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error getting image description.");
                throw new InvalidOperationException("Image description failed.", ex);
            }
        }


        private async Task<string> SendRequestAsync(object requestBody)
        {
            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_visionEndpoint}/openai/deployments/gpt-4-vision-preview/chat/completions?api-version=2024-02-15-preview", content);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<JsonElement>(responseString);

            return result.GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();
        }

        public void SomeMethod()
        {
            var collection = new List<int> { 1, 2, 3 };

            using var resource = new Resource();

            if (someCondition) // Ensure 'someCondition' is defined in the class
            {
                // ...existing code...
            } // Add missing closing brace
        }
    }
}
