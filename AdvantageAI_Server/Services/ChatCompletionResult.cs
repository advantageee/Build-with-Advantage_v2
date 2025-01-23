using System;
using System.Collections.Generic;
using Azure.AI.OpenAI;

namespace AdvantageAIWeb.Models.AI
{
    /// <summary>
    /// Represents a request for a chat completion.
    /// </summary>
    public class ChatCompletionResult
    {
        /// <summary>
        /// Gets the list of messages in the conversation.
        /// </summary>
        public List<ChatMessage> Messages { get; } = new List<ChatMessage>();

        /// <summary>
        /// Adds a message to the conversation history.
        /// </summary>
        /// <param name="message">The message to add.</param>
        /// <exception cref="ArgumentNullException">Thrown if the message is null.</exception>
        public void AddMessage(ChatMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "Message cannot be null.");
            }

            Messages.Add(message);
        }

        /// <summary>
        /// Validates the request to ensure it contains at least one message.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the request does not contain any messages.</exception>
        public void ValidateRequest()
        {
            if (Messages == null || Messages.Count == 0)
            {
                throw new InvalidOperationException("ChatCompletionRequest must contain at least one message.");
            }
        }

        public override string ToString()
        {
            return $"ChatCompletionRequest: {Messages.Count} message(s)";
        }
    }
}