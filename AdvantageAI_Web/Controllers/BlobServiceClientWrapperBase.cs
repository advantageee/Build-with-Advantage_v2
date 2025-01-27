using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AdvantageAI_Web.Controllers
{
    public class BlobServiceClientWrapperBase
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly ILogger<BlobServiceClientWrapperBase> _logger;
        private readonly string _containerName = "advantageai-uploads";

        public BlobServiceClientWrapperBase(BlobServiceClient blobServiceClient, ILogger<BlobServiceClientWrapperBase> logger)
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

        public BlobServiceClient GetBlobServiceClient()
        {
            return _blobServiceClient;
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

                var blobClient = containerClient.GetBlobClient(fileName);
                await blobClient.UploadAsync(fileStream);

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
