using System.IO;
using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    public interface IAdvantageAIService
    {
        Task GenerateContentAsync(string prompt);
        Task GenerateContentAsync(object prompt);
        Task GenerateImageCaptionAsync(Stream stream);
        Task GenerateImageCaptionAsync(object stream);
        Task TranslateContentAsync(string content, string targetLanguage);
        Task TranslateDocumentAsync(Stream stream, string targetLanguage);
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