namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem
{
    public class AmazonS3Provider : IStorageProvider
    {
        public void SaveFile(string fileName, byte[] fileData)
        {
            Console.WriteLine($"Saving {fileName} to Amazon S3...");
            // Logic for saving file to Amazon S3
        }
        public byte[] RetrieveFile(string fileName)
        {
            Console.WriteLine($"Retrieving {fileName} from Amazon S3...");
            // Logic for retrieving file from Amazon S3
            return Array.Empty<byte>();  // Sample return
        }
    }
}
