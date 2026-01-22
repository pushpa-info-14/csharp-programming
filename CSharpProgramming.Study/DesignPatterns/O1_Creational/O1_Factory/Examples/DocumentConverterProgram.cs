namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O1_Factory.Examples;

public class DocumentConverterProgram
{
	public interface IDocumentConverter
	{
		string Convert(string content);
		string TargetExtension { get; }
	}

	public class TxtConverter : IDocumentConverter
	{
		public string Convert(string content)
		{
			Console.WriteLine("Converting content to TXT format...");
			// Logic for TXT conversion, simplified for this example
			return content + " [Converted to TXT]";
		}

		public string TargetExtension => ".txt";
	}

	public class PdfConverter : IDocumentConverter
	{
		public string Convert(string content)
		{
			Console.WriteLine("Converting content to PDF format...");
			// Logic for PDF conversion, simplified for this example
			return content + " [Converted to PDF]";
		}

		public string TargetExtension => ".pdf";
	}

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

	public static class DocumentConverterFactory
	{
		public static IDocumentConverter CreateDocumentConverter(string format)
		{
			return format.ToLower() switch
			{
				"docx" => new DocxConverter(),
				"pdf" => new PdfConverter(),
				"txt" => new TxtConverter(),
				_ => throw new ArgumentException("Unsupported document format"),
			};
		}
	}

	public static void Test()
	{
		const string content = "This is the content for conversion";

		var converter = DocumentConverterFactory.CreateDocumentConverter("DOCX");
		var convertedContent = converter.Convert(content);
		Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");

		converter = DocumentConverterFactory.CreateDocumentConverter("PDF");
		convertedContent = converter.Convert(content);
		Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");

		converter = DocumentConverterFactory.CreateDocumentConverter("TXT");
		convertedContent = converter.Convert(content);
		Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
	}
}
