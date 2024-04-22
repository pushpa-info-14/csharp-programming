namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples
{
    public class DocumentServiceProgram
    {
        // Product(Interface)
        public interface IDocumentConverter
        {
            void Convert(string inputFile, string outputFile);
        }

        // Concrete Products
        public class PdfConverter : IDocumentConverter
        {
            public void Convert(string inputFile, string outputFile)
            {
                Console.WriteLine($"Converting {inputFile} to PDF and saving as {outputFile}.");
                // Actual PDF conversion logic goes here...
            }
        }

        public class DocxConverter : IDocumentConverter
        {
            public void Convert(string inputFile, string outputFile)
            {
                Console.WriteLine($"Converting {inputFile} to DOCX and saving as {outputFile}.");
                // Actual DOCX conversion logic goes here...
            }
        }

        public class TxtConverter : IDocumentConverter
        {
            public void Convert(string inputFile, string outputFile)
            {
                Console.WriteLine($"Converting {inputFile} to TXT and saving as {outputFile}.");
                // Actual TXT conversion logic goes here...
            }
        }

        // Creator(Abstract Class)
        public abstract class DocumentConverterFactory
        {
            public abstract IDocumentConverter CreateConverter();
        }

        // Concrete Creators
        public class PdfConverterFactory : DocumentConverterFactory
        {
            public override IDocumentConverter CreateConverter()
            {
                return new PdfConverter();
            }
        }

        public class DocxConverterFactory : DocumentConverterFactory
        {
            public override IDocumentConverter CreateConverter()
            {
                return new DocxConverter();
            }
        }

        public class TxtConverterFactory : DocumentConverterFactory
        {
            public override IDocumentConverter CreateConverter()
            {
                return new TxtConverter();
            }
        }

        // Client Code
        public class DocumentService
        {
            public void ExportDocument(DocumentConverterFactory factory, string inputFile, string outputFile)
            {
                IDocumentConverter converter = factory.CreateConverter();
                converter.Convert(inputFile, outputFile);
            }
        }

        public void Test()
        {
            var documentService = new DocumentService();
            // User wants to export to PDF:
            documentService.ExportDocument(new PdfConverterFactory(), "source.docx", "output.pdf");
            // User wants to export to DOCX:
            documentService.ExportDocument(new DocxConverterFactory(), "source.pdf", "output.docx");
            // User wants to export to TXT:
            documentService.ExportDocument(new TxtConverterFactory(), "source.pdf", "output.txt");
        }
    }
}
