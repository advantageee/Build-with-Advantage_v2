using AdvantageAI_Server.Services;
using AdvantageAIWeb.Models.AI;
using AdvantageAIWeb.Models.Chat;
using AdvantageAIWeb.ViewModels;
using Azure.AI.OpenAI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Interface for interacting with OpenAI services.
    /// </summary>
    public interface IOpenAIService
    {
        /// <summary>
        /// Generates a chat response based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The user-provided prompt.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the generated response.</returns>
        Task<string> GenerateChatResponseAsync(string prompt);

        /// <summary>
        /// Generates a code snippet based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The user-provided prompt describing the desired code snippet.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the generated code snippet.</returns>
        Task<string> GenerateCodeSnippetAsync(string prompt);
        Task<string> GenerateContentAsync(string prompt);
        AIResponse GetChatCompletion(List<ChatMessage> conversationHistory, string deploymentId);

        /// <summary>
        /// Gets a chat completion based on the provided conversation history and deployment ID.
        /// </summary>
        /// <param name="conversationHistory">The conversation history to base the response on.</param>
        /// <param name="deploymentId">The deployment ID to use for the request.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the AI response.</returns>
        Task<AIResponse> GetChatCompletionAsync(List<ChatMessage> conversationHistory, string deploymentId);
    }
}
