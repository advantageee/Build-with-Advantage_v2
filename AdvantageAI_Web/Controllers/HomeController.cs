using AdvantageAIWeb.Services.Interfaces;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using AdvantageAI_Web.Models.ViewModels;
using System.Web;
using static AdvantageAI_Web.App_Start.AdvantageAIService;
using AdvantageAI_Web.App_Start;

namespace AdvantageAI_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdvantageAIService _aiService;
        private readonly ITranslatorService _translatorService;
        private readonly IOpenAIService _openAIService;
        private readonly IVisionService _visionService;
        private readonly IDalleService _dalleService;
        private readonly ICodeGenerationService _codeGenerationService;
        private readonly AdvantageAIService.BlobServiceClient _blobServiceClient;
        private readonly MemoryStream _stream;
        private readonly ILogger<HomeController> _logger;
        private static readonly Task completedTaskInstance = Task.CompletedTask;
        private Task result;
        private readonly string _filePath;

        public HomeController(
            IAdvantageAIService aiService,
            ITranslatorService translatorService,
            IOpenAIService openAIService,
            IVisionService visionService,
            IDalleService dalleService,
            ICodeGenerationService codeGenerationService,
            AdvantageAIService.BlobServiceClient blobServiceClient,
            ILogger<HomeController> logger,
            string filePath)
        {
            _aiService = aiService ?? throw new ArgumentNullException(nameof(aiService));
            _translatorService = translatorService ?? throw new ArgumentNullException(nameof(translatorService));
            _openAIService = openAIService ?? throw new ArgumentNullException(nameof(openAIService));
            _visionService = visionService ?? throw new ArgumentNullException(nameof(visionService));
            _dalleService = dalleService ?? throw new ArgumentNullException(nameof(dalleService));
            _codeGenerationService = codeGenerationService ?? throw new ArgumentNullException(nameof(codeGenerationService));
            _blobServiceClient = blobServiceClient ?? throw new ArgumentNullException(nameof(blobServiceClient));
            _stream = new MemoryStream();
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            result = completedTaskInstance;
            _filePath = filePath;
        }

        // Index action for rendering the view
        public ActionResult Index()
        {
            var model = new HomeViewModel(); // Initialize with default values
            _logger.LogInformation("Index action called.");
            return View(model);
        }

        public async Task GetVAsync() => await result;

        // Action to handle content generation via AJAX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GenerateContent(string prompt)
        {
            try
            {
                var result = await _aiService.GenerateContentAsync(prompt);

                // Check if result is not null and contains valid data
                if (result != null)
                {
                    return Json(new
                    {
                        content = result.Content,
                        title = result.Title,
                        description = result.Description,
                        keywords = result.Keywords
                    });
                }

                return Json(new { error = "Content generation failed, no result returned." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating content");
                return Json(new { error = "Error generating content" });
            }
        }

        // Action to handle content translation via AJAX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> TranslateContent(string content, string targetLanguage)
        {
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(targetLanguage))
            {
                _logger.LogError("Content or Target Language is missing.");
                return Json(new { success = false, message = "Content or Target Language is missing" });
            }

            try
            {
                // Correct async call for translation
                var translationResult = await _aiService.TranslateContentAsync(content, targetLanguage);
                return Json(new { success = true, translatedContent = translationResult.TranslatedContent });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Translation failed: {ex.Message}");
                return Json(new { success = false, message = "Translation failed" });
            }
        }

        // Action to handle document upload
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UploadDocument(HttpPostedFileBase file)
        {
            if (file == null || file.ContentLength == 0)
            {
                _logger.LogError("No file uploaded.");
                return Json(new { success = false, message = "No file uploaded" });
            }

            try
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(filePath);

                // Process the uploaded document
                await _aiService.ProcessDocumentAsync(filePath);
                return Json(new { success = true, message = "Document processed successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Document upload failed: {ex.Message}");
                return Json(new { success = false, message = "Document upload failed" });
            }
        }

        // Action to handle code snippet generation via AJAX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GenerateCodeSnippet(string prompt, string language)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrEmpty(language))
            {
                _logger.LogError("Prompt or Language is missing.");
                return Json(new { success = false, message = "Prompt or Language is missing" });
            }

            try
            {
                var codeSnippet = await _codeGenerationService.GenerateCodeSnippetAsync(prompt, language);
                return Json(new { success = true, codeSnippet });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Code snippet generation failed: {ex.Message}");
                return Json(new { success = false, message = "Code snippet generation failed" });
            }
        }

        // Action to handle image generation via AJAX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GenerateImage(string prompt, string size, string style)
        {
            if (string.IsNullOrEmpty(prompt) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(style))
            {
                _logger.LogError("Prompt, Size, or Style is missing.");
                return Json(new { success = false, message = "Prompt, Size, or Style is missing" });
            }

            try
            {
                var imageResult = await _dalleService.GenerateImageAsync(prompt, size, style);
                return Json(new { success = true, imageUrl = imageResult });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Image generation failed: {ex.Message}");
                return Json(new { success = false, message = "Image generation failed" });
            }
        }

        // Action to handle image caption generation via AJAX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GenerateImageCaption(HttpPostedFileBase file)
        {
            if (file == null || file.ContentLength == 0)
            {
                _logger.LogError("No file uploaded.");
                return Json(new { success = false, message = "No file uploaded" });
            }

            try
            {
                using (var stream = file.InputStream)
                {
                    var caption = await _visionService.GenerateCaptionAsync(stream);
                    return Json(new { success = true, caption });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Image caption generation failed: {ex.Message}");
                return Json(new { success = false, message = "Image caption generation failed" });
            }
        }

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _stream?.Dispose();  // Dispose of the MemoryStream to release resources
            }
            base.Dispose(disposing);
        }
    }

    public interface ILogger<T>
    {
        void LogError(Exception ex, string v);
        void LogError(string v);
        void LogInformation(string v);
    }
}
