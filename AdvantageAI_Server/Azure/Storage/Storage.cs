using System;

namespace Azure
{
    internal class StorageService
    {
        internal class BlobServiceClient
        {
            private string connectionString;

            public BlobServiceClient(string connectionString)
            {
                this.connectionString = connectionString;
            }

            internal object GetBlobContainerClient(string containerName)
            {
                throw new NotImplementedException();
            }

            internal object GetBlobContainerClient(object containerName)
            {
                throw new NotImplementedException();
            }
        }
    }
}