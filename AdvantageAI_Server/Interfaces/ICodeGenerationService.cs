using System.Threading.Tasks;

namespace AdvantageAIWeb.Services.Interfaces
{
    /// <summary>
    /// Defines a service for generating code snippets based on user-provided prompts.
    /// </summary>
    public interface ICodeGenerationService
    {
        /// <summary>
        /// Generates a code snippet based on the provided prompt.
        /// </summary>
        /// <param name="prompt">The prompt describing the code to generate.</param>
        /// <returns>A task representing the asynchronous operation, with the generated code snippet as the result.</returns>
        /// <exception cref="ArgumentException">Thrown if the prompt is null or empty.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the code generation fails.</exception>
        Task<string> GenerateCodeSnippetAsync(string prompt, string language);
    }
}
