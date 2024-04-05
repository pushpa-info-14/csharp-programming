namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter
{
    public class DocumentServiceProgram
    {
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
