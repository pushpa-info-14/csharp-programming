﻿namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DocumentConversionSystem
{
    public static class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(string format)
        {
            switch (format.ToLower())
            {
                case "docx":
                    return new DocxConverter();
                case "pdf":
                    return new PdfConverter();
                case "txt":
                    return new TxtConverter();
                default:
                    throw new ArgumentException("Unsupported document format");
            }
        }
    }
}
