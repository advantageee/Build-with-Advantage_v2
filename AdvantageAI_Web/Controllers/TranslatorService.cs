using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using AdvantageAIWeb.Services.Interfaces;
using NLog;

namespace AdvantageAIWeb.Services
{
    public class TranslatorService : ITranslatorService
    {
        private readonly string _translatorApiKey;
        private readonly string _translatorEndpoint;
        private readonly HttpClient _httpClient;
        private readonly Logger _logger;
        private readonly JavaScriptSerializer _serializer;

        public TranslatorService(string apiKey, string endpoint)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey));
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentNullException(nameof(endpoint));

            _translatorApiKey = apiKey;
            _translatorEndpoint = endpoint;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _translatorApiKey);
            _logger = LogManager.GetCurrentClassLogger();
            _serializer = new JavaScriptSerializer();
        }

        public async Task<string> TranslateTextAsync(string text, string targetLanguage)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text cannot be null or empty.", nameof(text));
            if (string.IsNullOrWhiteSpace(targetLanguage))
                throw new ArgumentException("Target language cannot be null or empty.", nameof(targetLanguage));

            var requestBody = new[] { new { Text = text } };
            var json = _serializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync($"{_translatorEndpoint}/translate?api-version=3.0&to={targetLanguage}", content);
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = _serializer.Deserialize<TranslationResponse[]>(responseString);

                return responseObject[0].Translations[0].Text;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error translating text.");
                throw;
            }
        }
        public async Task<string> TranslateDocumentAsync(string documentPath, string targetLanguage)
        {
            if (string.IsNullOrWhiteSpace(documentPath) || !File.Exists(documentPath))
                throw new ArgumentException("Document path is invalid or the file does not exist.", nameof(documentPath));
            if (string.IsNullOrWhiteSpace(targetLanguage))
                throw new ArgumentException("Target language cannot be null or empty.", nameof(targetLanguage));

            try
            {
                // Use Task.Run to simulate asynchronous file I/O
                var text = await Task.Run(() => File.ReadAllText(documentPath));
                var translatedText = await TranslateTextAsync(text, targetLanguage);

                var translatedFileName = $"translated_{Path.GetFileName(documentPath)}";
                var translatedFilePath = Path.Combine(Path.GetDirectoryName(documentPath), translatedFileName);

                await Task.Run(() => File.WriteAllText(translatedFilePath, translatedText));
                return translatedFilePath;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error translating document.");
                throw;
            }
        }

                public Task<string> TranslateDocumentAsync(string blobUrl, object targetLanguage)
        {
            throw new NotImplementedException();
        }

        public Task<string> TranslateDocumentAsync(Stream stream, string targetLanguage)
        {
            throw new NotImplementedException();
        }

        public Task TranslateContentAsync(string content, string targetLanguage)
        {
            throw new NotImplementedException();
        }

        private class TranslationResponse
        {
            public Translation[] Translations { get; set; }
        }

        private class Translation
        {
            public string Text { get; set; }
            public string To { get; set; }
        }
    }
}
