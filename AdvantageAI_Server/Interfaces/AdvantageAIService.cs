using AdvantageAIWeb.Services.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Azure.Storage.Blobs;

namespace AdvantageAI_Web.App_Start
{
    public class AdvantageAIService : IAdvantageAIService
    {
        public Task<ContentGenerationResult> GenerateContentAsync(string prompt)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateImageCaptionAsync(Stream stream)
        {
            throw new NotImplementedException();
        }

        public Task ProcessDocumentAsync(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task ProcessDocumentAsync(object filePath)
        {
            throw new NotImplementedException();
        }

        public Task<TranslationResult> TranslateContentAsync(string content, string targetLanguage)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentTranslationResult> TranslateDocumentAsync(Stream stream, string targetLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
