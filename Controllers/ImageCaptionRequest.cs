using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AvantageAI_Server.ViewModels
{
    public class ImageCaptionViewModel
    {
        [Required(ErrorMessage = "Please upload an image file.")]
        public HttpPostedFileBase UploadedFile { get; set; }

        [Display(Name = "Generated Caption")]
        public string Caption { get; set; }

        public bool IsProcessing { get; set; }

        [Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; } = DateTime.Now;
        public object Image { get; internal set; }
    }
}
