using System;

namespace AdvantageAIWeb.Models.Chat
{
    public class ChatMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public ChatMessage()
        {
            Timestamp = DateTime.UtcNow;
        }

        public ChatMessage(string role, string content) : this()
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentNullException(nameof(role));
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentNullException(nameof(content));

            Role = role;
            Content = content;
        }
    }
}