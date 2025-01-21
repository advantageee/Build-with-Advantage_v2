using System;
using System.Collections.Generic;
using AdvantageAIWeb.Models.Chat;
using AdvantageAIWeb.ViewModels;

namespace AdvantageAIWeb.Models.AI
{
    public class AIModel : AIModelBase
    {
        public string Prompt { get; set; }
        public string LatestResponse { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }

    public class AIModelBase
    {
    }
}
