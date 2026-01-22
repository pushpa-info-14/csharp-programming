namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples;

public class SqlQueryBuilderProgram
{
	public class QueryBuilder
	{
		private string _select;
		private string _from;
		private string _where;

		public QueryBuilder Select(string columns)
		{
			_select = $"SELECT {columns}";
			return this;
		}

		public QueryBuilder From(string table)
		{
			_from = $"FROM {table}";
			return this;
		}

		public QueryBuilder Where(string condition)
		{
			_where = $"WHERE {condition}";
			return this;
		}

		public string Build()
		{
			return $"{_select} {_from} {_where}";
		}
	}

	public static void Test()
	{
		var query = new QueryBuilder()
			.Select("Name, Age")
			.From("Users")
			.Where("Age > 21")
			.Build();
		Console.WriteLine(query);  // Outputs: SELECT Name, Age FROM Users WHERE Age > 21
	}
}
