using System;

namespace AvantageAI_Server.Controllers
{
    public class ChatCompletionsOptions
    {
        public string Model { get; set; } = "gpt-4";
        public int MaxTokens { get; set; } = 1000;
        public double Temperature { get; set; } = 0.7;
        public int TopP { get; set; } = 1;
        public int N { get; set; } = 1;

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Model))
            {
                throw new InvalidOperationException("Model cannot be null or empty.");
            }

            if (MaxTokens <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxTokens), "MaxTokens must be greater than 0.");
            }

            if (Temperature < 0 || Temperature > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(Temperature), "Temperature must be between 0 and 1.");
            }

            if (TopP < 0 || TopP > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(TopP), "TopP must be between 0 and 1.");
            }

            if (N <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(N), "N must be greater than 0.");
            }
        }
    }
}
