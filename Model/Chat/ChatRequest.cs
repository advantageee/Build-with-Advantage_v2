using System;
using System.ComponentModel.DataAnnotations;

namespace AdvantageAIWeb.Models.AI
{
    /// <summary>
    /// Model for Chat request.
    /// </summary>
    public class ChatRequest
    {
        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; private set; }

        public ChatRequest(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be null or empty.", nameof(message));
            }

            Message = message.Trim();
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Message))
            {
                throw new InvalidOperationException("Message is required for a valid chat request.");
            }
        }

        public override string ToString()
        {
            return $"ChatRequest: {Message}";
        }
    }
}
