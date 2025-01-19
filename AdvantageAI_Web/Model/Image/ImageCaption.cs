using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AdvantageAI_Web.Models.ViewModels
{
    /// <summary>
    /// ViewModel for handling image caption generation requests.
    /// </summary>
    public class ImageCaptionRequestViewModel
    {
        /// <summary>
        /// Gets or sets the uploaded image file.
        /// </summary>
        [Required(ErrorMessage = "Please upload an image file.")]
        public HttpPostedFileBase Image { get; set; }

        /// <summary>
        /// Gets or sets the target language for the caption.
        /// </summary>
        [Required(ErrorMessage = "Target language is required.")]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// Validates the ViewModel's properties.
        /// </summary>
        public void Validate()
        {
            if (Image == null || Image.ContentLength <= 0)
            {
                throw new InvalidOperationException("A valid image file is required.");
            }

            if (string.IsNullOrWhiteSpace(TargetLanguage))
            {
                throw new InvalidOperationException("Target language is required.");
            }
        }

        /// <summary>
        /// Resets the ViewModel's properties.
        /// </summary>
        public void Reset()
        {
            Image = null;
            TargetLanguage = string.Empty;
        }

        public override string ToString()
        {
            return $"ImageCaptionRequestViewModel: Image='{Image?.FileName}', TargetLanguage='{TargetLanguage}'";
        }
    }
}
