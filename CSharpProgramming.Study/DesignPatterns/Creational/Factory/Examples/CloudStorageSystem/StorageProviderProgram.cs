namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem
{
    public class StorageProviderProgram
    {
        public void Test()
        {
            var storageProvider = StorageProviderFactory.CreateStorageProvider("AmazonS3");
            storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider

            storageProvider = StorageProviderFactory.CreateStorageProvider("AzureBlob");
            storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider

            storageProvider = StorageProviderFactory.CreateStorageProvider("GoogleCloud");
            storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider
        }
    }
}
