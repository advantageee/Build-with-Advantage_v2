using System;

namespace Azure
{
    internal class Storage
    {
        internal class Blobs
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

            internal class Models
            {
                public class BlobProperties
                {
                }

                public class PublicAccessType
                {
                    public PublicAccessType Blob { get; internal set; }
                }

                internal class BlobUploadOptions
                {
                    public bool Overwrite { get; set; }
                }
            }
        }
    }
}