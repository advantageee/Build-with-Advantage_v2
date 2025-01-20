using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.WebPages.Html;


namespace AdvantageAIWeb.ViewModels
{
    /// <summary>
    /// ViewModel for uploading documents and specifying translation details.
    /// </summary>
    public class UploadDocumentViewModel
    {
        /// <summary>
        /// Gets or sets the list of supported languages for translation.
        /// </summary>
        public List<SelectListItem> Languages { get; private set; } = new List<SelectListItem>();
        public string SelectedLanguage { get; set; }
        /// <summary>
        /// Gets or sets the uploaded document.
        /// </summary>
        [Required(ErrorMessage = "Please upload a file.")]
        public HttpPostedFileBase File { get; set; }

        /// <summary>
        /// Gets or sets the target language for translation.
        /// </summary>
        [Required(ErrorMessage = "Please select a target language.")]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// Populates the list of supported languages.
        /// </summary>
        /// <param name="languages">List of languages in the format (value, text).</param>
        public void PopulateLanguages(IEnumerable<(string Value, string Text)> languages)
        {
            if (languages == null)
            {
                throw new ArgumentNullException(nameof(languages), "Languages cannot be null.");
            }

            Languages.Clear();
            foreach (var (value, text) in languages)
            {
                Languages.Add(new SelectListItem { Value = value, Text = text });
            }
        }

        /// <summary>
        /// Validates the ViewModel's properties.
        /// </summary>
        public void Validate()
        {
            if (File == null || File.ContentLength <= 0)
            {
                throw new InvalidOperationException("A valid file must be uploaded.");
            }

            if (string.IsNullOrWhiteSpace(TargetLanguage))
            {
                throw new InvalidOperationException("Target language is required.");
            }
        }

        public override string ToString()
        {
            return $"UploadDocumentViewModel: File='{File?.FileName}', TargetLanguage='{TargetLanguage}', LanguagesCount={Languages.Count}";
        }

        internal void PopulateLanguages(object value)
        {
            throw new NotImplementedException();
        }
    }
}
