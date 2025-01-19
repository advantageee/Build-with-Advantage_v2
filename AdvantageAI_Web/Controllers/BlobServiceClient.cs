using Azure.Storage.Blobs;
using System;

namespace AvantageAI_Server.Controllers
{
    public class BlobServiceClient
    {
        public string BlobConnectionString { get; }

        public BlobServiceClient(string blobConnectionString)
        {
            BlobConnectionString = blobConnectionString ??
                throw new ArgumentNullException(nameof(blobConnectionString));
        }

        internal BlobContainerClient GetBlobContainerClient(string blobContainerName)
        {
            if (string.IsNullOrWhiteSpace(blobContainerName))
                throw new ArgumentException("Container name cannot be null or empty", nameof(blobContainerName));

            return new BlobContainerClient(BlobConnectionString, blobContainerName);
        }
    }
}