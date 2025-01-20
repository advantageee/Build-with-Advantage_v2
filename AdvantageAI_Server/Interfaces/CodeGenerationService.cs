using System;
using System.Threading.Tasks;
using AdvantageAIWeb.Services.Interfaces;
using Microsoft.Build.Utilities;
using NLog;

namespace AdvantageAIWeb.Services
{
    public class CodeGenerationService : ICodeGenerationService
    {
        private readonly IOpenAIService _openAIService;
        private readonly NLog.Logger _logger;

        public CodeGenerationService(IOpenAIService openAIService)
        {
            _openAIService = openAIService ?? throw new ArgumentNullException(nameof(openAIService));
            _logger = LogManager.GetCurrentClassLogger();
        }

        public async Task<string> GenerateCodeSnippetAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
            {
                _logger.Warn("Prompt is null or empty.");
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));
            }

            try
            {
                _logger.Info("Generating code snippet for the provided prompt.");
                var codeSnippet = await _openAIService.GenerateCodeSnippetAsync(prompt);
                _logger.Info("Code snippet generated successfully.");
                return codeSnippet;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error generating code snippet for prompt: {prompt}");
                throw new InvalidOperationException("Failed to generate code snippet. See inner exception for details.", ex);
            }
        }

        public Task<string> GenerateCodeSnippetAsync(string prompt, string language)
        {
            throw new NotImplementedException();
        }
    }
}
