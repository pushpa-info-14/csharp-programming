namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples;

public class HtmlTagBuilderProgram
{
	public class HtmlTagBuilder
	{
		private readonly string _tagName;
		private string? _content;
		private readonly Dictionary<string, string> _attributes = new();

		public HtmlTagBuilder(string tagName)
		{
			_tagName = tagName;
		}

		public HtmlTagBuilder WithContent(string content)
		{
			_content = content;
			return this;
		}

		public HtmlTagBuilder AddAttribute(string attribute, string value)
		{
			_attributes[attribute] = value;
			return this;
		}

		public override string ToString()
		{
			var attributes = string.Join(" ", _attributes.Select(a => $"{a.Key}='{a.Value}'"));
			return $"<{_tagName} {attributes}>{_content}</{_tagName}>";
		}
	}

	public static void Test()
	{
		var tag = new HtmlTagBuilder("div")
			.AddAttribute("class", "container")
			.AddAttribute("id", "mainContainer")
			.WithContent("Hello, world!")
			.ToString();

		Console.WriteLine(tag);
		// Outputs: <div class='container' id='mainContainer'>Hello, world!</div>
	}
}
