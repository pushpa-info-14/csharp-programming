using System.Text;

namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O4_Builder.Examples;

public class StringBuilderProgram
{
	public class CustomString
	{
		private readonly StringBuilder _stringBuilder = new();

		public void Append(string str)
		{
			_stringBuilder.Append(str);
		}

		public override string ToString()
		{
			return _stringBuilder.ToString();
		}
	}

	public class StringConstructor
	{
		private readonly CustomString _customString = new();

		public StringConstructor AppendLine(string line)
		{
			_customString.Append(line + Environment.NewLine);
			return this;
		}

		public StringConstructor AppendSpace(string word)
		{
			_customString.Append(word + " ");
			return this;
		}

		public StringConstructor AppendWords(params string[] words)
		{
			foreach (var word in words)
			{
				AppendSpace(word);
			}
			return this;
		}

		public CustomString Build()
		{
			return _customString;
		}
	}

	public static void Test()
	{
		var constructor = new StringConstructor();

		constructor.AppendLine("Hello, Builder pattern!")
			.AppendWords("This", "is", "a", "custom", "string", "builder!")
			.AppendLine("It's efficient.");

		var customStr = constructor.Build();

		Console.WriteLine(customStr);
	}
}
