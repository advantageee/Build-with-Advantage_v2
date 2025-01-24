using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AdvantageAIWeb.Models.Chat;
using AdvantageAIWeb.Services.Interfaces;
using AdvantageAIWeb.ViewModels;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using NLog;
using OpenAI.Chat;
using ChatMessage = AdvantageAIWeb.Models.Chat.ChatMessage;

namespace AdvantageAIWeb.Controllers {
    public class HomeController : Controller
    {
        private readonly IAdvantageAIService _aiService;
        private readonly ITranslatorService _translatorService;
        private readonly IOpenAIService _openAIService;
        private readonly IVisionService _visionService;
        private readonly IDalleService _dalleService;
        private readonly ICodeGenerationService _codeGenerationService;
        private readonly BlobServiceClient _blobServiceClient;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public HomeController(
        IAdvantageAIService aiService,
        ITranslatorService translatorService,
        IOpenAIService openAIService,
        IVisionService visionService,
        IDalleService dalleService,
        ICodeGenerationService codeGenerationService,
        BlobServiceClient blobServiceClient)
        {
            _aiService = aiService;
            _translatorService = translatorService;
            _openAIService = openAIService;
            _visionService = visionService;
            _dalleService = dalleService;
            _codeGenerationService = codeGenerationService;
            _blobServiceClient = blobServiceClient;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > GenerateContent(string prompt)
        {
            try {
                if (string.IsNullOrEmpty(prompt))
                    return Json(new { success = false, error = "Prompt is required." });

                var result = await _aiService.GenerateContentAsync(prompt);
                return Json(new {
                    success = true,
                    content = result.Content,
                    title = result.Title,
                    description = result.Description,
                    keywords = result.Keywords
                });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating content");
                return Json(new { success = false, error = "Error generating content." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > TranslateContent(string content, string targetLanguage)
        {
            try {
                if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(targetLanguage))
                    return Json(new { success = false, error = "Content and target language are required." });

                var result = await _aiService.TranslateContentAsync(content, targetLanguage);
                return Json(new {
                    success = true,
                    translatedContent = result.TranslatedContent,
                    title = result.Title,
                    description = result.Description,
                    keywords = result.Keywords
                });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error translating content.");
                return Json(new { success = false, error = "Error translating content." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > GenerateImageCaption(HttpPostedFileBase imageFile)
        {
            try {
                if (imageFile == null || imageFile.ContentLength == 0)
                    return Json(new { success = false, error = "Please upload an image." });

                var result = await _aiService.GenerateImageCaptionAsync(imageFile.InputStream);
                return Json(new { success = true, caption = result });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating image caption.");
                return Json(new { success = false, error = "Error generating image caption." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > UploadDocument(HttpPostedFileBase file, string targetLanguage)
        {
            try {
                if (file == null || file.ContentLength == 0)
                    return Json(new { success = false, error = "Please select a file." });

                if (string.IsNullOrEmpty(targetLanguage))
                    return Json(new { success = false, error = "Please select a target language." });

                var result = await _aiService.TranslateDocumentAsync(file.InputStream, targetLanguage);
                return Json(new {
                    success = true,
                    translatedFileUrl = result.FileUrl,
                    fileName = result.FileName
                });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error uploading document.");
                return Json(new { success = false, error = "Error uploading document." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > GenerateCodeSnippet(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt)) {
                return Json(new { success = false, error = "Prompt cannot be empty." });
            }

            try {
                string snippet = await _codeGenerationService.GenerateCodeSnippetAsync(prompt);
                return Json(new { success = true, snippet });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating code snippet.");
                return Json(new { success = false, error = "Error generating code snippet." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > GenerateImage(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt)) {
                return Json(new { success = false, error = "Prompt cannot be empty." });
            }

            try {
                string imageUrl = await _dalleService.GenerateImageAsync(prompt);
                return Json(new { success = true, imageUrl });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error generating image.");
                return Json(new { success = false, error = "Error generating image." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > Chat(string userMessage)
        {
            if (string.IsNullOrWhiteSpace(userMessage)) {
                return Json(new { success = false, error = "Message cannot be empty." });
            }

            try {
                string response = await _openAIService.GenerateChatResponseAsync(userMessage);
                return Json(new { success = true, response });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error processing chat.");
                return Json(new { success = false, error = "Error processing chat." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult > TranslateAll(string targetLanguage, string message, string title, string description, string keywords)
        {
            if (string.IsNullOrWhiteSpace(targetLanguage)) {
                return Json(new { success = false, error = "Target language is required." });
            }

            try {
                var translatedMessage = await _translatorService.TranslateTextAsync(message, targetLanguage);
                var translatedTitle = await _translatorService.TranslateTextAsync(title, targetLanguage);
                var translatedDescription = await _translatorService.TranslateTextAsync(description, targetLanguage);
                var translatedKeywords = await _translatorService.TranslateTextAsync(keywords, targetLanguage);

                return Json(new
                    {
                        success = true,
                        translatedMessage,
                        translatedTitle,
                        translatedDescription,
                        translatedKeywords
                    });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error translating content.");
                return Json(new { success = false, error = "Error translating content." });
            }
        }
    }
}
