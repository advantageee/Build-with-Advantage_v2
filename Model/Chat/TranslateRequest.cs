using System;
using System.ComponentModel.DataAnnotations;

namespace AdvantageAIWeb.ViewModels
{
    /// <summary>
    /// Represents a translation request containing the text to translate and the target language.
    /// </summary>
    public class TranslateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest"/> class.
        /// </summary>
        public TranslateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateRequest"/> class with specified text and target language.
        /// </summary>
        /// <param name="text">The text to translate.</param>
        /// <param name="targetLanguage">The target language code (e.g., "es" for Spanish).</param>
        public TranslateRequest(string text, string targetLanguage = "en")
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text cannot be null or empty.", nameof(text));
            }

            Text = text.Trim();
            TargetLanguage = string.IsNullOrWhiteSpace(targetLanguage) ? "en" : targetLanguage.Trim();
        }

        /// <summary>
        /// Gets the text to be translated.
        /// </summary>
        [Required(ErrorMessage = "Text is required.")]
        [Display(Name = "Text to Translate")]
        public string Text { get; private set; }

        /// <summary>
        /// Gets the target language code (e.g., "es" for Spanish).
        /// </summary>
        [Required(ErrorMessage = "Target language is required.")]
        [Display(Name = "Target Language")]
        public string TargetLanguage { get; private set; }

        /// <summary>
        /// Validates the request to ensure required properties are set.
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                throw new InvalidOperationException("Text is required for a valid translation request.");
            }

            if (string.IsNullOrWhiteSpace(TargetLanguage))
            {
                throw new InvalidOperationException("Target language is required for a valid translation request.");
            }
        }

        /// <summary>
        /// Provides a string representation of the translation request.
        /// </summary>
        public override string ToString()
        {
            return $"TranslateRequest: Text='{Text}', TargetLanguage='{TargetLanguage}'";
        }
    }
}
