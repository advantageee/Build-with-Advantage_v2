using System;

namespace AdvantageAIWeb.Models.AI
{
    public class ServiceResponse
    {
        public bool IsSuccess { get; private set; }
        public string Content { get; private set; }
        public string ErrorMessage { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Keywords { get; private set; }

        public static ServiceResponse Success(string content, string title = null, string description = null, string keywords = null)
        {
            return new ServiceResponse
            {
                IsSuccess = true,
                Content = content,
                Title = title,
                Description = description,
                Keywords = keywords
            };
        }

        public static ServiceResponse Failure(string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                throw new ArgumentException("ErrorMessage cannot be null or empty for a failed response.", nameof(errorMessage));
            }

            return new ServiceResponse
            {
                IsSuccess = false,
                ErrorMessage = errorMessage
            };
        }

        public void Validate()
        {
            if (IsSuccess && string.IsNullOrWhiteSpace(Content))
            {
                throw new InvalidOperationException("Content must be provided for a successful response.");
            }

            if (!IsSuccess && string.IsNullOrWhiteSpace(ErrorMessage))
            {
                throw new InvalidOperationException("ErrorMessage must be provided for a failed response.");
            }
        }
    }
}
