using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System.Memory.Data;
using static AdvantageAI_Web.App_Start.AdvantageAIService;

namespace AdvantageAI_Web.Controllers
{
    public class BlobServiceClientWrapper
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly ILogger<BlobServiceClientWrapper> _logger;
        private readonly string _containerName = "advantageai-uploads";

        public BlobServiceClientWrapper(IConfiguration configuration, ILogger<BlobServiceClientWrapper> logger)
        {
            var connectionString = configuration.GetConnectionString("AzureStorage");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Azure Storage connection string not found in configuration");
            }

            _blobServiceClient = new BlobServiceClient(connectionString);
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                await containerClient.CreateIfNotExistsAsync();

                var blobClient = containerClient.GetBlobClient(fileName);
                await blobClient.UploadAsync(fileStream, new BlobUploadOptions { Overwrite = true });

                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error uploading file {FileName} to blob storage", fileName);
                throw;
            }
        }

        public async Task<Stream> DownloadFileAsync(string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                if (!await blobClient.ExistsAsync())
                {
                    throw new FileNotFoundException($"File {fileName} not found in blob storage");
                }

                var memoryStream = new MemoryStream();
                await blobClient.DownloadToAsync(memoryStream);
                memoryStream.Position = 0;

                return memoryStream;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error downloading file {FileName} from blob storage", fileName);
                throw;
            }
        }

        public async Task DeleteFileAsync(string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                await blobClient.DeleteIfExistsAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting file {FileName} from blob storage", fileName);
                throw;
            }
        }

        public async Task<BlobProperties> GetFilePropertiesAsync(string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                if (!await blobClient.ExistsAsync())
                {
                    throw new FileNotFoundException($"File {fileName} not found in blob storage");
                }

                var properties = await blobClient.GetPropertiesAsync();
                return properties.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting properties for file {FileName} from blob storage", fileName);
                throw;
            }
        }

        public async Task<bool> FileExistsAsync(string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                var exists = await blobClient.ExistsAsync();
                return exists.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking existence of file {FileName} in blob storage", fileName);
                throw;
            }
        }

        public async Task SetMetadataAsync(string fileName, IDictionary<string, string> metadata)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                if (!await blobClient.ExistsAsync())
                {
                    throw new FileNotFoundException($"File {fileName} not found in blob storage");
                }

                await blobClient.SetMetadataAsync(metadata);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error setting metadata for file {FileName} in blob storage", fileName);
                throw;
            }
        }

        private async Task EnsureContainerExistsAsync()
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
            await containerClient.CreateIfNotExistsAsync();
        }
    }
}
