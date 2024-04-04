namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DocumentConversionSystem
{
    public class DocxConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to DOCX format...");
            // Logic for DOCX conversion, simplified for this example
            return content + " [Converted to DOCX]";
        }

        public string TargetExtension => ".docx";
    }
}
