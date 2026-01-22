namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype.Examples;

public class HistoricalStatesForUndoActions
{
	// Prototype - IDocumentStatePrototype Interface
	public interface IDocumentStatePrototype
	{
		IDocumentStatePrototype Clone();
	}

	// Concrete Prototype - DocumentState Class
	public class DocumentState : IDocumentStatePrototype
	{
		public string Content { get; set; }

		public string FontName { get; set; }

		public int FontSize { get; set; }

		public IDocumentStatePrototype Clone()
		{
			return new DocumentState
			{
				Content = Content,
				FontName = FontName,
				FontSize = FontSize
			};
		}
	}

	// Client Code
	public static void Test()
	{
		Stack<DocumentState> history = new();

		// Initial document state
		var document = new DocumentState
		{
			Content = "Hello, world!",
			FontName = "Arial",
			FontSize = 12
		};

		// Save initial state
		history.Push((DocumentState)document.Clone());

		// User changes the font
		document.FontName = "Times New Roman";

		// Save state after changing font
		history.Push((DocumentState)document.Clone());

		// User adds more content
		document.Content += "\nAdding some more text.";

		// Save state after adding more content
		history.Push((DocumentState)document.Clone());

		// User decides to undo
		if (history.Count > 0)
		{
			document = history.Pop();
		}

		// Display the document's state to simulate how it would appear in the editor
		Console.WriteLine($"Content: {document.Content}");
		Console.WriteLine($"Font: {document.FontName}");
		Console.WriteLine($"Size: {document.FontSize}");
	}
}
