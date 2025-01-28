using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AdvantageAIWeb.Services.Interfaces;
using Azure;
using Microsoft.Graph.Chats.Item.Members.Add;
using Newtonsoft.Json;
using NLog;

namespace AdvantageAI_Server.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly string _apiKey;
        private readonly string _endpoint;
        private readonly HttpClient _httpClient;
        private readonly Logger _logger;

        public object RequestBody { get; private set; }  // Added to implement interface

        object IOpenAIService.RequestBody => throw new NotImplementedException();

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

        public string GenerateCodeSnippet(string prompt)  // Implemented interface method
        {
            return GenerateCodeSnippetAsync(prompt).GetAwaiter().GetResult();
        }

        public async Task<string> GenerateCodeSnippetAsync(string prompt)
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
                _logger.Debug($"Code snippet completionResponse: {response}");
                var result = JsonConvert.DeserializeObject<ChatCompletionResult>(response);
                return result?.Messages?.FirstOrDefault()?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating code snippet.");
                throw new InvalidOperationException("Failed to generate code snippet.", ex);
            }
        }
        public async Task<AIResponse> GetChatCompletionAsync(List<ChatMessage> conversationHistory)
        {
            var chatCompletionResult = await GetChatCompletionAsync(messages: conversationHistory, "default");
            return new AIResponse { Content = chatCompletionResult.Messages.FirstOrDefault()?.Content };
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
                _logger.Debug($"Chat completionResponse: {response}");
                var result = JsonConvert.DeserializeObject<ChatCompletionResult>(response);
                return result?.Messages?.FirstOrDefault()?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating chat completionResponse.");
                throw new InvalidOperationException("Failed to generate chat completionResponse.", ex);
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
                _logger.Debug($"Content completionResponse: {response}");
                var result = JsonConvert.DeserializeObject<ChatCompletionResult>(response);
                return result?.Messages?.FirstOrDefault()?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating content");
                throw new InvalidOperationException("Failed to generate content.", ex);
            }
        }

        public async Task<string> GenerateCodeSnippetAsync(string prompt, string language)
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
                },
                language = language
            };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                _logger.Debug($"Code snippet completionResponse: {response}");
                var result = JsonConvert.DeserializeObject<ChatCompletionResult>(response);
                return result?.Messages?.FirstOrDefault()?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating code snippet.");
                throw new InvalidOperationException("Failed to generate code snippet.", ex);
            }
        }

        public async Task<string> SendPostRequestAsync(string path, object requestBody)
        {
            RequestBody = requestBody; // Set the RequestBody property
            var json = JsonConvert.SerializeObject(requestBody);
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

        public ChatCompletionResult GetChatCompletion(List<ChatCompletionResult.ChatMessage> messages, string model)
        {
            // Implementation here
            throw new NotImplementedException();
        }

        public Task<ChatCompletionResult> GetChatCompletionAsync(List<ChatCompletionResult.ChatMessage> messages)
        {
            // Implementation here
            throw new NotImplementedException();
        }

        public Task<ChatCompletionResult> GetChatCompletionAsync(List<ChatMessage> messages, string model)
        {
            // Implementation here
            throw new NotImplementedException();
        }

        public async Task<ChatCompletionResult> SomeMethodAsync()
        {
            var result = await SomeAsyncOperation();
            return result;
        }

        private Task<ChatCompletionResult> SomeAsyncOperation()
        {
            // Implementation here
            throw new NotImplementedException();
        }

        Task<string> IOpenAIService.GenerateChatResponseAsync(string prompt)
        {
            throw new NotImplementedException();
        }

        string IOpenAIService.GenerateCodeSnippet(string prompt)
        {
            throw new NotImplementedException();
        }

        Task<string> IOpenAIService.GenerateCodeSnippetAsync(string prompt, string language)
        {
            throw new NotImplementedException();
        }

        Task<string> IOpenAIService.GenerateContentAsync(string prompt)
        {
            throw new NotImplementedException();
        }

        AIResponse IOpenAIService.GetChatCompletion(List<AdvantageAIWeb.Models.AI.ChatCompletionResult.ChatMessage> conversationHistory, string deploymentId)
        {
            throw new NotImplementedException();
        }

        Task<AIResponse> IOpenAIService.GetChatCompletionAsync(List<ChatMessage> conversationHistory, string deploymentId)
        {
            throw new NotImplementedException();
        }

        Task<AIResponse> IOpenAIService.GetChatCompletionAsync(List<AdvantageAIWeb.Models.AI.ChatCompletionResult.ChatMessage> conversationHistory)
        {
            throw new NotImplementedException();
        }

        Task<AIResponse> IOpenAIService.GetChatCompletionAsync(List<Azure.AI.OpenAI.ChatMessage> conversationHistory, string deploymentId)
        {
            throw new NotImplementedException();
        }

        Task<AddResponse> IOpenAIService.GetChatCompletionAsync(List<ChatMessage> conversationHistory)
        {
            throw new NotImplementedException();
        }

        Task<string> IOpenAIService.SendPostRequestAsync(string path, object requestBody)
        {
            throw new NotImplementedException();
        }
    }

    public class AIResponse
    {
        public string Content { get; set; }
    }

    public class ChatMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }
    }

    public class ChatCompletionResult
    {
        public List<ChatMessage> Messages { get; set; }

        public class ChatMessage
        {
            public string Role { get; set; }
            public string Content { get; set; }
        }
    }
}