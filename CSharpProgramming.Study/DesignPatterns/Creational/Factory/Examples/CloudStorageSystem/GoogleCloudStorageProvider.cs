namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem
{
    public class GoogleCloudStorageProvider : IStorageProvider
    {
        public void SaveFile(string fileName, byte[] fileData)
        {
            Console.WriteLine($"Saving {fileName} to Google Cloud Storage...");
            // Logic for saving file to Google Cloud Storage
        }
        public byte[] RetrieveFile(string fileName)
        {
            Console.WriteLine($"Retrieving {fileName} from Google Cloud Storage...");
            // Logic for retrieving file from Google Cloud Storage
            return Array.Empty<byte>();  // Sample return
        }
    }
}
