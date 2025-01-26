using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using static AdvantageAI_Web.App_Start.AdvantageAIService;
using NLog;
using BlobServiceClient = AdvantageAI_Web.App_Start.AdvantageAIService.BlobServiceClient;
using Microsoft.Extensions.Configuration;

namespace AdvantageAI_Web.Controllers
{
    public class BlobServiceClientWrapperBase1
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName = "advantageai-uploads";
        private readonly ILogger<BlobServiceClientWrapper> _logger;

        public async Task<BlobProperties> GetFilePropertiesAsync(string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);
                if (!await blobClient.ExistsAsync())
                {
                    throw new FileNotFoundException($"File {fileName} not found");
                }
                var blobProperties = await blobClient.GetPropertiesAsync();
                return blobProperties.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting properties for {FileName}", fileName);
                throw;
            }
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);
                var blobClient = containerClient.GetBlobClient(fileName);
                await blobClient.UploadAsync(fileStream, overwrite: true);
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error uploading file {FileName}", fileName);
                throw;
            }
        }
    }

    public class BlobServiceClientWrapper : BlobServiceClientWrapperBase1
    {
        private readonly App_Start.AdvantageAIService.BlobServiceClient _blobServiceClient;
        private readonly ILogger<BlobServiceClientWrapper> _logger;

        public BlobServiceClientWrapper(IConfiguration configuration, ILogger<BlobServiceClientWrapper> logger)
        {
            var connectionString = configuration.GetConnectionString("AzureStorage");
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));
            _blobServiceClient = new BlobServiceClient(connectionString);
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public ILogger<BlobServiceClientWrapper> Logger { get; }
    }
}
