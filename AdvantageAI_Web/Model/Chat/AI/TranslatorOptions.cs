using System;

namespace AdvantageAIWeb.Models
{
    public class TranslatorOptions
    {
        public string ApiKey { get; private set; }
        public string Endpoint { get; private set; }
        public string Region { get; private set; }

        public TranslatorOptions(string apiKey, string endpoint, string region)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("ApiKey cannot be null or empty.", nameof(apiKey));

            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentException("Endpoint cannot be null or empty.", nameof(endpoint));

            if (string.IsNullOrWhiteSpace(region))
                throw new ArgumentException("Region cannot be null or empty.", nameof(region));

            ApiKey = apiKey;
            Endpoint = endpoint;
            Region = region;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(ApiKey))
                throw new InvalidOperationException("ApiKey is required.");

            if (string.IsNullOrWhiteSpace(Endpoint))
                throw new InvalidOperationException("Endpoint is required.");

            if (string.IsNullOrWhiteSpace(Region))
                throw new InvalidOperationException("Region is required.");
        }
    }
}
