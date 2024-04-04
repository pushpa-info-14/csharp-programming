namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem
{
    public interface IStorageProvider
    {
        void SaveFile(string fileName, byte[] fileData);
        byte[] RetrieveFile(string fileName);
    }
}
