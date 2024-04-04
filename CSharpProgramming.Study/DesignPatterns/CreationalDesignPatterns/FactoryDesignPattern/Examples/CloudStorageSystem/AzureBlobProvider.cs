﻿namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.CloudStorageSystem
{
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
            return Array.Empty<byte>();  // Sample return
        }
    }
}
