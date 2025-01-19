using System;
using System.ComponentModel.DataAnnotations;

namespace AdvantageAIWeb.ViewModels
{
    public class CodeSnippetViewModel
    {
        [Required(ErrorMessage = "Prompt is required.")]
        public string Prompt { get; set; }

        public string GeneratedCode { get; private set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Prompt))
            {
                throw new InvalidOperationException("Prompt cannot be null or empty.");
            }
        }

        public void SetGeneratedCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentException("Generated code cannot be null or empty.", nameof(code));
            }

            GeneratedCode = code;
        }

        public void ClearGeneratedCode()
        {
            GeneratedCode = null;
        }
    }
}
