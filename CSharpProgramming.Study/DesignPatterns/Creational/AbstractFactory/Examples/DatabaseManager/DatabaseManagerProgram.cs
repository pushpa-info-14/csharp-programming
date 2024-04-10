namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager
{
    public class DatabaseManagerProgram
    {
        public void Test()
        {
            Console.WriteLine("Using SQL Server:");
            var sqlFactory = new SqlServerFactory();
            var sqlManager = new DatabaseManager(sqlFactory);
            sqlManager.PerformDatabaseOperations("SELECT * FROM Users");

            Console.WriteLine("Using Oracle:");
            var oracleFactory = new OracleFactory();
            var oracleManager = new DatabaseManager(oracleFactory);
            oracleManager.PerformDatabaseOperations("SELECT * FROM Employees");
        }
    }
}
