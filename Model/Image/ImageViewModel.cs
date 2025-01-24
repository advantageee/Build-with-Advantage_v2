using AdvantageAIWeb.Models.Chat;
using System;
using System.Collections.Generic;

namespace AdvantageAIWeb.ViewModels
{
    public class ImageGenerationViewModel
    {
        public string Prompt { get; set; }
        public string Size { get; set; } = "1024x1024";
        public string Style { get; set; } = "vivid";
        public string GeneratedImageUrl { get; set; }

        public class CodeSnippetViewModel
        {
            public string Prompt { get; set; }
            public string Language { get; set; } = "csharp";
            public string GeneratedCode { get; set; }
        }

        public class ChatMessageViewModel
        {
            public string Role { get; set; }
            public string Content { get; set; }

            public static ChatMessageViewModel FromChatMessage(ChatMessage message)
            {
                return new ChatMessageViewModel
                {
                    Role = message.Role,
                    Content = message.Content
                };
            }
        }

        public class ChatViewModel
        {
            public string Message { get; set; }
            public string Response { get; set; }
            public List<ChatMessageViewModel> ConversationHistory { get; set; } = new List<ChatMessageViewModel>();


            public static implicit operator ChatViewModel(string v)
            {
                return new ChatViewModel { Message = v };
            }
        }
    }
}