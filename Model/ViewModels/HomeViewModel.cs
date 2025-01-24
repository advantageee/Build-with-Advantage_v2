using AdvantageAIWeb.Models.AI;
using AdvantageAIWeb.Models.Chat;
using AdvantageAIWeb.ViewModels;
using AvantageAI_Server.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AdvantageAI_Web.Models.ViewModels
{
    public class HomeViewModel
    {

        /// <summary>
        /// Model for AI interactions.
        /// </summary>
        public AIModel AIModel { get; set; } = new AIModel();

        /// <summary>
        /// Model for image generation prompts.
        /// </summary>
        public AdvantageAIWeb.ViewModels.ImagePromptViewModel ImagePromptModel { get; set; } = new AdvantageAIWeb.ViewModels.ImagePromptViewModel();

        /// <summary>
        /// Model for chat interactions.
        /// </summary>
        public AdvantageAIWeb.ViewModels.ChatViewModel ChatModel { get; set; } = new AdvantageAIWeb.ViewModels.ChatViewModel();

        /// <summary>
        /// Model for image caption generation.
        /// </summary>
        public AvantageAI_Server.ViewModels.ImageCaptionViewModel ImageCaptionModel { get; set; } = new AvantageAI_Server.ViewModels.ImageCaptionViewModel();
        /// <summary>
        /// Model for code snippet generation.
        /// </summary>
        public AdvantageAIWeb.ViewModels.CodeSnippetViewModel CodeSnippetModel { get; set; } = new AdvantageAIWeb.ViewModels.CodeSnippetViewModel();

        /// <summary>
        /// List of supported languages for selection.
        /// </summary>
        public List<SelectListItem> Languages { get; set; } = new List<SelectListItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel"/> class.
        /// </summary>
        public HomeViewModel()
        {
            Languages.Add(new SelectListItem { Value = "af", Text = "Afrikaans" });
            Languages.Add(new SelectListItem { Value = "ar", Text = "Arabic" });
            Languages.Add(new SelectListItem { Value = "bg", Text = "Bulgarian" });
            Languages.Add(new SelectListItem { Value = "bn", Text = "Bangla" });
            Languages.Add(new SelectListItem { Value = "bs", Text = "Bosnian" });
            Languages.Add(new SelectListItem { Value = "ca", Text = "Catalan" });
            Languages.Add(new SelectListItem { Value = "cs", Text = "Czech" });
            Languages.Add(new SelectListItem { Value = "cy", Text = "Welsh" });
            Languages.Add(new SelectListItem { Value = "da", Text = "Danish" });
            Languages.Add(new SelectListItem { Value = "de", Text = "German" });
            Languages.Add(new SelectListItem { Value = "el", Text = "Greek" });
            Languages.Add(new SelectListItem { Value = "en", Text = "English" });
            Languages.Add(new SelectListItem { Value = "es", Text = "Spanish" });
            Languages.Add(new SelectListItem { Value = "et", Text = "Estonian" });
            Languages.Add(new SelectListItem { Value = "fa", Text = "Persian" });
            Languages.Add(new SelectListItem { Value = "fi", Text = "Finnish" });
            Languages.Add(new SelectListItem { Value = "fil", Text = "Filipino" });
            Languages.Add(new SelectListItem { Value = "fj", Text = "Fijian" });
            Languages.Add(new SelectListItem { Value = "fr", Text = "French" });
            Languages.Add(new SelectListItem { Value = "ga", Text = "Irish" });
            Languages.Add(new SelectListItem { Value = "gu", Text = "Gujarati" });
            Languages.Add(new SelectListItem { Value = "he", Text = "Hebrew" });
            Languages.Add(new SelectListItem { Value = "hi", Text = "Hindi" });
            Languages.Add(new SelectListItem { Value = "hr", Text = "Croatian" });
            Languages.Add(new SelectListItem { Value = "ht", Text = "Haitian Creole" });
            Languages.Add(new SelectListItem { Value = "hu", Text = "Hungarian" });
            Languages.Add(new SelectListItem { Value = "id", Text = "Indonesian" });
            Languages.Add(new SelectListItem { Value = "is", Text = "Icelandic" });
            Languages.Add(new SelectListItem { Value = "it", Text = "Italian" });
            Languages.Add(new SelectListItem { Value = "ja", Text = "Japanese" });
            Languages.Add(new SelectListItem { Value = "kk", Text = "Kazakh" });
            Languages.Add(new SelectListItem { Value = "km", Text = "Khmer" });
            Languages.Add(new SelectListItem { Value = "kn", Text = "Kannada" });
            Languages.Add(new SelectListItem { Value = "ko", Text = "Korean" });
            Languages.Add(new SelectListItem { Value = "lt", Text = "Lithuanian" });
            Languages.Add(new SelectListItem { Value = "lv", Text = "Latvian" });
            Languages.Add(new SelectListItem { Value = "mg", Text = "Malagasy" });
            Languages.Add(new SelectListItem { Value = "mi", Text = "Maori" });
            Languages.Add(new SelectListItem { Value = "ml", Text = "Malayalam" });
            Languages.Add(new SelectListItem { Value = "mr", Text = "Marathi" });
            Languages.Add(new SelectListItem { Value = "ms", Text = "Malay" });
            Languages.Add(new SelectListItem { Value = "mt", Text = "Maltese" });
            Languages.Add(new SelectListItem { Value = "mww", Text = "Hmong Daw" });
            Languages.Add(new SelectListItem { Value = "nb", Text = "Norwegian" });
            Languages.Add(new SelectListItem { Value = "nl", Text = "Dutch" });
            Languages.Add(new SelectListItem { Value = "otq", Text = "Querétaro Otomi" });
            Languages.Add(new SelectListItem { Value = "pa", Text = "Punjabi" });
            Languages.Add(new SelectListItem { Value = "pl", Text = "Polish" });
            Languages.Add(new SelectListItem { Value = "pt", Text = "Portuguese (Brazil)" });
            Languages.Add(new SelectListItem { Value = "pt-pt", Text = "Portuguese (Portugal)" });
            Languages.Add(new SelectListItem { Value = "ro", Text = "Romanian" });
            Languages.Add(new SelectListItem { Value = "ru", Text = "Russian" });
            Languages.Add(new SelectListItem { Value = "sk", Text = "Slovak" });
            Languages.Add(new SelectListItem { Value = "sl", Text = "Slovenian" });
            Languages.Add(new SelectListItem { Value = "sm", Text = "Samoan" });
            Languages.Add(new SelectListItem { Value = "sq", Text = "Albanian" });
            Languages.Add(new SelectListItem { Value = "sr", Text = "Serbian (Cyrillic)" });
            Languages.Add(new SelectListItem { Value = "sr-latn", Text = "Serbian (Latin)" });
            Languages.Add(new SelectListItem { Value = "sv", Text = "Swedish" });
            Languages.Add(new SelectListItem { Value = "sw", Text = "Swahili" });
            Languages.Add(new SelectListItem { Value = "ta", Text = "Tamil" });
            Languages.Add(new SelectListItem { Value = "te", Text = "Telugu" });
            Languages.Add(new SelectListItem { Value = "th", Text = "Thai" });
            Languages.Add(new SelectListItem { Value = "tlh-Latn", Text = "Klingon (Latin)" });
            Languages.Add(new SelectListItem { Value = "tlh-Piqd", Text = "Klingon (plqaD)" });
            Languages.Add(new SelectListItem { Value = "to", Text = "Tongan" });
            Languages.Add(new SelectListItem { Value = "tr", Text = "Turkish" });
            Languages.Add(new SelectListItem { Value = "ty", Text = "Tahitian" });
            Languages.Add(new SelectListItem { Value = "uk", Text = "Ukrainian" });
            Languages.Add(new SelectListItem { Value = "ur", Text = "Urdu" });
            Languages.Add(new SelectListItem { Value = "vi", Text = "Vietnamese" });
            Languages.Add(new SelectListItem { Value = "yua", Text = "Yucatec Maya" });
            Languages.Add(new SelectListItem { Value = "yue", Text = "Cantonese (Traditional)" });
            Languages.Add(new SelectListItem { Value = "zh-Hans", Text = "Chinese (Simplified)" });
            Languages.Add(new SelectListItem { Value = "zh-Hant", Text = "Chinese (Traditional)" });
        }
    }
    public class AIModel
    {
        public string Prompt { get; set; }
        public string LatestResponse { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }
}
