using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;
using static AdvantageAI_Web.App_Start.AdvantageAIService;
using Microsoft.Azure.Storage.Blob;
using Azure.Storage.Blobs.Models;

namespace AdvantageAI_Web.Controllers
{
    public class BlobServiceClientWrapperBase
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName = "advantageai-uploads";
        private readonly ILogger<BlobServiceClientWrapperBase> _logger;

        internal PublicAccessType PublicAccessType { get; private set; }

        public BlobServiceClientWrapperBase(BlobServiceClient blobServiceClient, ILogger<BlobServiceClientWrapperBase> logger)
        {
            _blobServiceClient = blobServiceClient;
            _logger = logger;
        }

        public async Task<Azure.Storage.Blobs.Models.BlobProperties> GetFilePropertiesAsync(string fileName)
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
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error uploading file {FileName}", fileName);
                throw;
            }
        }
    }
}
