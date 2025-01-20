using System.IO;
using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    public interface IAdvantageAIService
    {
        Task<ContentGenerationResult> GenerateContentAsync(string prompt);  // Changed
        Task<ContentGenerationResult> GenerateContentAsync(object prompt);  // Changed
        Task<string> GenerateImageCaptionAsync(Stream stream);  // Changed
        Task<string> GenerateImageCaptionAsync(object stream);  // Changed
        Task<TranslationResult> TranslateContentAsync(string content, string targetLanguage);  // Changed
        Task<DocumentTranslationResult> TranslateDocumentAsync(Stream stream, string targetLanguage);  // Changed
    }

    public class ContentGenerationResult
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }

    public class TranslationResult
    {
        public string TranslatedContent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
    }

    public class DocumentTranslationResult
    {
        public string FileUrl { get; set; }
        public string FileName { get; set; }
    }
}