namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem
{
    public static class StorageProviderFactory
    {
        public static IStorageProvider CreateStorageProvider(string providerName)
        {
            switch (providerName.ToLower())
            {
                case "amazons3":
                    return new AmazonS3Provider();
                case "azureblob":
                    return new AzureBlobProvider();
                case "googlecloud":
                    return new GoogleCloudStorageProvider();
                default:
                    throw new ArgumentException("Invalid storage provider name");
            }
        }
    }
}
