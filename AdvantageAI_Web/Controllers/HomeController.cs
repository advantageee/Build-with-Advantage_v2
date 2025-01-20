using AdvantageAIWeb.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;
using System;
using AvantageAI_Server.Controllers;
using AdvantageAI_Web.Models.ViewModels;


public class HomeController : Controller
{
    private readonly IAdvantageAIService _aiService;
    private readonly ITranslatorService _translatorService;
    private readonly IOpenAIService _openAIService;
    private readonly IVisionService _visionService;
    private readonly IDalleService _dalleService;
    private readonly ICodeGenerationService _codeGenerationService;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly MemoryStream _stream;
    private readonly ILogger<HomeController> _logger;
    private Task result;

    public HomeController(
        IAdvantageAIService aiService,
        ITranslatorService translatorService,
        IOpenAIService openAIService,
        IVisionService visionService,
        IDalleService dalleService,
        ICodeGenerationService codeGenerationService,
        BlobServiceClient blobServiceClient,
        ILogger<HomeController> logger)
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
        result = Task.CompletedTask; // Initialize the result field
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
            var translatedContent = await _translatorService.TranslateContentAsync(content, targetLanguage);

            // Return translated content
            return Json(new { success = true, translatedContent });
        }
        catch (Exception ex)
        {
            _logger.LogError($"Translation failed: {ex.Message}");
            return Json(new { success = false, message = "Translation failed" });
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

