using System.Collections.Generic;

namespace AdvantageAIWeb.ViewModels
{
    public class ChatMessageViewModel
    {
        public string Role { get; set; }
        public string Content { get; set; }

        public static ChatMessageViewModel FromChatMessage(Models.Chat.ChatMessage message)
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

        public static List<ChatMessageViewModel> MapFromChatMessages(List<Models.Chat.ChatMessage> messages)
        {
            var viewModels = new List<ChatMessageViewModel>();
            if (messages != null)
            {
                foreach (var msg in messages)
                {
                    viewModels.Add(ChatMessageViewModel.FromChatMessage(msg));
                }
            }
            return viewModels;
        }
    }
}