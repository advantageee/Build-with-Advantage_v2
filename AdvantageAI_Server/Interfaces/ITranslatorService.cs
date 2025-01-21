using System.IO;
using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    public interface ITranslatorService
    {
        Task<string> TranslateTextAsync(string text, string targetLanguage);
        Task<string> TranslateDocumentAsync(string filePathOrUrl, string targetLanguage);
        Task<string> TranslateDocumentAsync(Stream stream, string targetLanguage);
    }
}
