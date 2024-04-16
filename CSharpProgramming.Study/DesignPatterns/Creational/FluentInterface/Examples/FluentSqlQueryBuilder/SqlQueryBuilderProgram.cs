namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentSqlQueryBuilder
{
    public class SqlQueryBuilderProgram
    {
        public void Test()
        {
            var query = new QueryBuilder()
                .Select("Name, Age")
                .From("Users")
                .Where("Age > 21")
                .Build();
            Console.WriteLine(query);  // Outputs: SELECT Name, Age FROM Users WHERE Age > 21
        }
    }
}
