using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace AdvantageAI_Web.Controllers
{
    public class BlobServiceClientWrapperBase1 : IEquatable<BlobServiceClientWrapperBase1>
    {
        protected readonly BlobServiceClient _blobServiceClient; // Correct instance type
        private readonly string _containerName = "advantageai-uploads";
        private readonly ILogger<BlobServiceClientWrapperBase1> _logger;

        public BlobServiceClientWrapperBase1(BlobServiceClient blobServiceClient, ILogger<BlobServiceClientWrapperBase1> logger)
        {
            _blobServiceClient = blobServiceClient ?? throw new ArgumentNullException(nameof(blobServiceClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public override bool Equals(object obj)
        {
            return obj is BlobServiceClientWrapperBase1 @base &&
                   EqualityComparer<BlobServiceClient>.Default.Equals(_blobServiceClient, @base._blobServiceClient) &&
                   _containerName == @base._containerName &&
                   EqualityComparer<ILogger<BlobServiceClientWrapperBase1>>.Default.Equals(_logger, @base._logger);
        }

        public bool Equals(BlobServiceClientWrapperBase1 other)
        {
            return other is not null &&
                   EqualityComparer<BlobServiceClient>.Default.Equals(_blobServiceClient, other._blobServiceClient) &&
                   _containerName == other._containerName &&
                   EqualityComparer<ILogger<BlobServiceClientWrapperBase1>>.Default.Equals(_logger, other._logger);
        }

        public async Task<BlobProperties> GetFilePropertiesAsync(string fileName)
        {
            try
            {
                // Using instance reference instead of static reference
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

        public override int GetHashCode()
        {
            int hashCode = -814239533;
            hashCode = hashCode * -1521134295 + EqualityComparer<BlobServiceClient>.Default.GetHashCode(_blobServiceClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_containerName);
            hashCode = hashCode * -1521134295 + EqualityComparer<ILogger<BlobServiceClientWrapperBase1>>.Default.GetHashCode(_logger);
            return hashCode;
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

                // Corrected method call to ensure it operates on the right instance
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

        public static bool operator ==(BlobServiceClientWrapperBase1 left, BlobServiceClientWrapperBase1 right)
        {
            return EqualityComparer<BlobServiceClientWrapperBase1>.Default.Equals(left, right);
        }

        public static bool operator !=(BlobServiceClientWrapperBase1 left, BlobServiceClientWrapperBase1 right)
        {
            return !(left == right);
        }
    }

    public class BlobServiceClientWrapper : BlobServiceClientWrapperBase1
    {
        public BlobServiceClientWrapper(IConfiguration configuration, ILogger<BlobServiceClientWrapper> logger)
            : base(new BlobServiceClient(configuration.GetConnectionString("AzureStorage")), (ILogger<BlobServiceClientWrapperBase1>)logger)
        {
        }
    }
}
