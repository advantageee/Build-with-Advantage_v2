using System;
using System.Configuration;
using System.Xml;

namespace AdvantageAIWeb.Configuration
{
    /// <summary>
    /// Represents the configuration settings for the Advantage AI services.
    /// </summary>
    public class ServiceConfig : IConfigurationSectionHandler
    {
        public string TranslatorApiKey { get; private set; }
        public string TranslatorEndpoint { get; private set; }
        public string OpenAIApiKey { get; private set; }
        public string OpenAIEndpoint { get; private set; }
        public string VisionApiKey { get; private set; }
        public string VisionEndpoint { get; private set; }
        public string DalleApiKey { get; private set; }
        public string DalleEndpoint { get; private set; }

        /// <summary>
        /// Parses the serviceConfig section from the web.config file.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        /// <param name="configContext">The configuration context.</param>
        /// <param name="section">The XML node representing the configuration section.</param>
        /// <returns>A populated <see cref="ServiceConfig"/> instance.</returns>
        public object Create(object parent, object configContext, XmlNode section)
        {
            if (section == null)
                throw new ArgumentNullException(nameof(section), "The serviceConfig section is missing or null.");

            var config = new ServiceConfig();

            foreach (XmlNode childNode in section.ChildNodes)
            {
                if (childNode.NodeType != XmlNodeType.Element)
                    continue;

                string value = childNode.InnerText?.Trim();
                if (string.IsNullOrEmpty(value))
                    throw new ConfigurationErrorsException($"{childNode.Name} cannot be null or empty.");

                switch (childNode.Name)
                {
                    case "TranslatorApiKey":
                        config.TranslatorApiKey = value;
                        break;
                    case "TranslatorEndpoint":
                        config.TranslatorEndpoint = value;
                        break;
                    case "OpenAIApiKey":
                        config.OpenAIApiKey = value;
                        break;
                    case "OpenAIEndpoint":
                        config.OpenAIEndpoint = value;
                        break;
                    case "VisionApiKey":
                        config.VisionApiKey = value;
                        break;
                    case "VisionEndpoint":
                        config.VisionEndpoint = value;
                        break;
                    case "DalleApiKey":
                        config.DalleApiKey = value;
                        break;
                    case "DalleEndpoint":
                        config.DalleEndpoint = value;
                        break;
                    default:
                        throw new ConfigurationErrorsException($"Unknown configuration element: {childNode.Name}");
                }
            }

            // Validate all endpoints
            config.ValidateEndpoints();

            return config;
        }

        /// <summary>
        /// Validates all endpoint URIs.
        /// </summary>
        private void ValidateEndpoints()
        {
            ValidateUri(TranslatorEndpoint, nameof(TranslatorEndpoint));
            ValidateUri(OpenAIEndpoint, nameof(OpenAIEndpoint));
            ValidateUri(VisionEndpoint, nameof(VisionEndpoint));
            ValidateUri(DalleEndpoint, nameof(DalleEndpoint));
        }

        /// <summary>
        /// Validates if the URI is well-formed and absolute.
        /// </summary>
        /// <param name="uri">The URI to validate.</param>
        /// <param name="propertyName">The name of the property being validated.</param>
        private void ValidateUri(string uri, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(uri) || !Uri.TryCreate(uri, UriKind.Absolute, out _))
            {
                throw new ConfigurationErrorsException($"{propertyName} is not a valid absolute URI: '{uri}'");
            }
        }
    }
}
