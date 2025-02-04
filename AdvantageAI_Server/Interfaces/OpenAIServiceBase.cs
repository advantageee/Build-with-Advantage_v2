﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static AdvantageAIWeb.Models.AI.ChatCompletionResult;

namespace AdvantageAI_Server.Services
{
    public class OpenAIServiceBase
    {
        private readonly string _apiKey;
        private readonly string _endpoint;
        private readonly HttpClient _httpClient;
        private readonly Logger _logger;

        public object RequestBody { get; private set; }

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

        public string GenerateCodeSnippet(string prompt) => GenerateChatResponseAsync($"Generate code snippet: {prompt}").GetAwaiter().GetResult();

        public Task<string> GenerateCodeSnippetAsync(string prompt)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GenerateCodeSnippetAsync(string prompt, string language)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            if (string.IsNullOrWhiteSpace(language))
            {
                throw new ArgumentException("Language cannot be null or empty.", nameof(language));
            }

            var requestBody = new
            {
                messages = new[]
                {
                    new { role = "system", content = $"Generate a code snippet in {language}." },
                    new { role = "user", content = prompt }
                }
            };

            try
            {
                var response = await SendPostRequestAsync("/chat/completions", requestBody);
                _logger.Debug($"Code snippet response: {response}");
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return result?.Messages?[0]?.Content ?? string.Empty;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating code snippet.");
                throw new InvalidOperationException("Failed to generate code snippet.", ex);
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

        public AIResponse GetChatCompletion(List<ChatMessage> conversationHistory, string deploymentId)
        {
            if (conversationHistory == null || conversationHistory.Count == 0)
            {
                throw new ArgumentException("Conversation history cannot be null or empty.", nameof(conversationHistory));
            }

            var messages = conversationHistory.Select(msg => new { role = msg.Role.ToString().ToLowerInvariant(), content = msg.Content }).ToArray();
            var requestBody = new { messages };

            try
            {
                var response = SendPostRequestAsync($"/chat/completions?deploymentId={deploymentId}", requestBody).GetAwaiter().GetResult();
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return new AIResponse { Content = result?.Messages?[0]?.Content };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error getting chat completion");
                throw new InvalidOperationException("Failed to get chat completion.", ex);
            }
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
                var response = await SendPostRequestAsync($"/chat/completions?deploymentId={deploymentId}", requestBody);
                var result = JsonSerializer.Deserialize<ChatCompletionResult>(response);
                return new AIResponse { Content = result?.Messages?[0]?.Content };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error getting chat completion");
                throw new InvalidOperationException("Failed to get chat completion.", ex);
            }
        }
         public async Task<string> SendPostRequestAsync(string path, object requestBody)
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
    }
}