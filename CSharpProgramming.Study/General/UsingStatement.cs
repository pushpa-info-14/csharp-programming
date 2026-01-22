
namespace CSharpProgramming.Study.General
{
	public static class UsingStatement
	{
		public static void Test1()
		{
			const string manyLines = @"This is line one
                This is line two
                Here is line three
                The penultimate line is line four
                This is the final, fifth line.";

			using var reader = new StringReader(manyLines);
			string? item;
			do
			{
				item = reader.ReadLine();
				Console.WriteLine(item);
			} while (item != null);
		}

		public static void Test2()
		{
			const string manyLines = @"This is line one
                This is line two
                Here is line three
                The penultimate line is line four
                This is the final, fifth line.";

			using var reader = new StringReader(manyLines);
			string? item;
			do
			{
				item = reader.ReadLine();
				Console.WriteLine(item);
			} while (item != null);
		}
	}
}
