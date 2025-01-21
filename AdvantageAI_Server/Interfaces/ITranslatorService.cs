using System.IO;
using System.Threading.Tasks;


namespace AdvantageAIWeb.Services.Interfaces
{
    public interface ITranslatorService
    {
        Task<string> TranslateAsync(string content, string targetLanguage);
        Task TranslateContentAsync(string content, string targetLanguage);
    }
}
