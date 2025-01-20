using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdvantageAIWeb.Models.Image;
using AdvantageAIWeb.Services;
using AdvantageAIWeb.Services.Interfaces;
using Logger = NLog.Logger;

public class DalleService : IDalleService
{
    private readonly string _dalleApiKey;
    private readonly string _dalleEndpoint;
    private readonly HttpClient _httpClient;
    private readonly Logger _logger;

    public DalleService()
    {
    }

    public DalleService(string apiKey, string endpoint)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ArgumentNullException(nameof(apiKey));
        if (string.IsNullOrWhiteSpace(endpoint))
            throw new ArgumentNullException(nameof(endpoint));

        _dalleApiKey = apiKey;
        _dalleEndpoint = endpoint;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("api-key", _dalleApiKey);
        _logger = LogManager.GetCurrentClassLogger();
    }

    public async Task<ImageResult> GenerateImageAsync(ImagePromptRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request));

        request.Validate();

        var json = JsonSerializer.Serialize(new
        {
            prompt = request.Prompt,
            size = request.Size,
            style = request.ImageStyle,
            quality = request.ImageQuality,
            n = 1
        });

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.PostAsync($"{_dalleEndpoint}/openai/deployments/dalle3/images/generations?api-version=2024-02-15-preview", content);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(responseString);

            var imageUrl = jsonResponse.GetProperty("data")[0].GetProperty("url").GetString();
            var revisedPrompt = jsonResponse.GetProperty("data")[0].GetProperty("revised_prompt").GetString();

            return new ImageResult(imageUrl, revisedPrompt);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error generating image.");
            throw;
        }
    }

    public Task<string> GenerateImageAsync(string prompt, string size)
    {
        throw new NotImplementedException();
    }

    public Task GenerateImageAsync(string prompt, string size, string style)
    {
        throw new NotImplementedException();
    }
}
