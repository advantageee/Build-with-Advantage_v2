using System;

namespace AdvantageAIWeb.Models.AI
{
    public class AIResponse
    {
        public string Content { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }

        public void Validate()
        {
            if (IsSuccess && string.IsNullOrWhiteSpace(Content))
            {
                throw new InvalidOperationException("Content cannot be empty when IsSuccess is true.");
            }

            if (!IsSuccess && string.IsNullOrWhiteSpace(ErrorMessage))
            {
                throw new InvalidOperationException("ErrorMessage must be provided when IsSuccess is false.");
            }
        }
    }

    public class ChatChoice
    {
        public Message Message { get; set; }

        public ChatChoice(Message message)
        {
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }

    public class Message
    {
        public string Role { get; private set; }
        public string Content { get; private set; }

        public Message(string role, string content)
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role cannot be null or empty.", nameof(role));

            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content cannot be null or empty.", nameof(content));

            Role = role;
            Content = content;
        }
    }
}
