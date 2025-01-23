namespace Azure.Storage.Blobs
{
    public class BlobServiceClient
    {
        private readonly string _connectionString;

        public BlobServiceClient(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BlobContainerClient GetBlobContainerClient(string containerName)
        {
            return new BlobContainerClient(_connectionString, containerName);
        }
    }

    public class BlobContainerClient
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public BlobContainerClient(string connectionString, string containerName)
        {
            _connectionString = connectionString;
            _containerName = containerName;
        }

        public async Task CreateIfNotExistsAsync()
        {
            // Implementation for creating the container if it doesn't exist
        }

        public BlobClient GetBlobClient(string blobName)
        {
            return new BlobClient(_connectionString, _containerName, blobName);
        }
    }

    public class BlobClient
    {
        private readonly string _connectionString;
        private readonly string _containerName;
        private readonly string _blobName;

        public BlobClient(string connectionString, string containerName, string blobName)
        {
            _connectionString = connectionString;
            _containerName = containerName;
            _blobName = blobName;
        }

        public async Task UploadAsync(Stream stream, BlobUploadOptions options)
        {
            // Implementation for uploading the blob
        }

        public Uri Uri => new Uri($"https://{_connectionString}.blob.core.windows.net/{_containerName}/{_blobName}");
    }

    public class BlobUploadOptions
    {
        public bool Overwrite { get; set; }
    }
}
