namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

public class StorageProviderProgram
{
	public interface IStorageProvider
	{
		void SaveFile(string fileName, byte[] fileData);

		byte[] RetrieveFile(string fileName);
	}

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
			return [];  // Sample return
		}
	}

	public class AzureBlobProvider : IStorageProvider
	{
		public void SaveFile(string fileName, byte[] fileData)
		{
			Console.WriteLine($"Saving {fileName} to Azure Blob Storage...");
			// Logic for saving file to Azure Blob Storage
		}

		public byte[] RetrieveFile(string fileName)
		{
			Console.WriteLine($"Retrieving {fileName} from Azure Blob Storage...");
			// Logic for retrieving file from Azure Blob Storage
			return [];  // Sample return
		}
	}

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
			return [];  // Sample return
		}
	}

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

	public static void Test()
	{
		var storageProvider = StorageProviderFactory.CreateStorageProvider("AmazonS3");
		storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider

		storageProvider = StorageProviderFactory.CreateStorageProvider("AzureBlob");
		storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider

		storageProvider = StorageProviderFactory.CreateStorageProvider("GoogleCloud");
		storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });   // Example of using the storage provider
	}
}
