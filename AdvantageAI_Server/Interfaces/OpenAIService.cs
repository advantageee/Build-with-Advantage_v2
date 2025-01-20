using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdvantageAIWeb.Services.Interfaces;
using Azure.AI.OpenAI;
using NLog;
using RestSharp;

namespace AdvantageAI_Server.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly string _apiKey;
        private readonly string _endpoint;
        private readonly HttpClient _httpClient;
        private readonly Logger _logger;

        public object RequestBody { get; private set; }

        public OpenAIService(string apiKey, string endpoint)
        {
            _logger = LogManager.GetCurrentClassLogger();

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                _logger.Error("API key is null or empty.");
                throw new ArgumentNullException(nameof(apiKey), "API key must be provided.");
            }

            if (string.IsNullOrWhiteSpace(endpoint))
            {
                _logger.Error("Endpoint is null or empty.");
                throw new ArgumentNullException(nameof(endpoint), "Endpoint must be provided.");
            }

            _apiKey = apiKey;
            _endpoint = endpoint;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("api-key", _apiKey);
        }

        public async Task<string> GenerateChatResponseAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            var requestBody = new
            {
                messages = new[]
                {
                    new { role = "user", content = prompt }
                }
            };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                _logger.Debug($"Chat response: {response}");
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return result?.Messages?[0]?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating chat response.");
                throw new InvalidOperationException("Failed to generate chat response.", ex);
            }
        }

        public async Task<string> GenerateContentAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            var requestBody = new
            {
                messages = new[]
                {
                    new { role = "system", content = "Generate creative content based on the following prompt." },
                    new { role = "user", content = prompt }
                },
                temperature = 0.7,
                max_tokens = 500
            };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                _logger.Debug($"Content response: {response}");
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return result?.Messages?[0]?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating content");
                throw new InvalidOperationException("Failed to generate content.", ex);
            }
        }

        private async Task<string> SendPostRequestAsync(string path, object requestBody)
        {
            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var url = $"{_endpoint}/openai/deployments/gpt-35-turbo{path}?api-version=2024-02-15-preview";
                _logger.Debug($"Sending request to: {url}");
                _logger.Debug($"Request body: {json}");

                var response = await _httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                _logger.Debug($"Response status: {response.StatusCode}");
                _logger.Debug($"Response body: {responseString}");

                response.EnsureSuccessStatusCode();
                return responseString;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in SendPostRequestAsync");
                throw;
            }
        }

        public string GenerateCodeSnippet(string prompt) => GenerateChatResponseAsync($"Generate code snippet: {prompt}").GetAwaiter().GetResult();

        public async Task<AIResponse> GetChatCompletionAsync(List<ChatMessage> conversationHistory, string deploymentId)
        {
            if (conversationHistory == null || conversationHistory.Count == 0)
            {
                throw new ArgumentException("Conversation history cannot be null or empty.", nameof(conversationHistory));
            }

            var messages = conversationHistory.Select(msg => new { role = msg.Role.ToString().ToLowerInvariant(), content = msg.Content }).ToArray();
            var requestBody = new { messages };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return new AIResponse { Content = result?.Messages?[0]?.Content };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error getting chat completion");
                throw new InvalidOperationException("Failed to get chat completion.", ex);
            }
        }
       public Task<string> GenerateCodeSnippetAsync(string prompt)
        {
            throw new NotImplementedException();
        }

       public async Task<AIResponse> GetChatCompletionAsync(List<ChatMessage> conversationHistory)
        {
            if (conversationHistory == null || conversationHistory.Count == 0)
            {
                throw new ArgumentException("Conversation history cannot be null or empty.", nameof(conversationHistory));
            }

            var messages = conversationHistory.Select(msg => new { role = msg.Role.ToString().ToLowerInvariant(), content = msg.Content }).ToArray();
            var requestBody = new { messages };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return new AIResponse { Content = result?.Messages?[0]?.Content };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error getting chat completion");
                throw new InvalidOperationException("Failed to get chat completion.", ex);
            }
        }

        public AIResponse GetChatCompletion(List<ChatMessage> conversationHistory, string deploymentId)
        {
            throw new NotImplementedException();
        }
             
    }

    public class AIResponse
    {
        public string Content { get; internal set; }
    }

    internal class ChatCompletionResult
    {
        public List<ChatMessage> Messages { get; set; }
    }

    internal class ChatMessageModel
    {
        public int Role { get; }
        public string Content { get; }
        public string V { get; }

        public ChatMessageModel(int role, string content)
        {
            Role = role;
            Content = content;
        }

        public ChatMessageModel(string v, string content)
        {
            V = v;
            Content = content;
        }

        public override bool Equals(object obj)
        {
            return obj is ChatMessageModel other &&
                   Role == other.Role &&
                   Content == other.Content;
        }

        public override int GetHashCode()
        {
            int hashCode = -281754749;
            hashCode = hashCode * -1521134295 + Role.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Content);
            return hashCode;
        }
    }
}