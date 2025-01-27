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
        protected readonly BlobServiceClient _blobServiceClient; // Changed to protected
        private readonly string _containerName = "advantageai-uploads";
        private readonly ILogger<BlobServiceClientWrapper> _logger;

        public BlobServiceClientWrapperBase1(BlobServiceClient blobServiceClient, ILogger<BlobServiceClientWrapper> logger)
        {
            _blobServiceClient = blobServiceClient ?? throw new ArgumentNullException(nameof(blobServiceClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

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
        public BlobServiceClientWrapper(IConfiguration configuration, ILogger<BlobServiceClientWrapper> logger)
            : base(new BlobServiceClient(configuration.GetConnectionString("AzureStorage")), logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public ILogger<BlobServiceClientWrapper> Logger { get; }
    }
}
