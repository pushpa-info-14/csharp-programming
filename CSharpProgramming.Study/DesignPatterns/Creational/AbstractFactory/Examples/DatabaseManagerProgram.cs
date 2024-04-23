namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples
{
    public class DatabaseManagerProgram
    {
        // Abstract Products
        public interface ICommand
        {
            void Execute(string query);
        }

        public interface IConnection
        {
            void OpenConnection();
        }

        // Concrete Products for Sql Server
        public class SqlServerCommand : ICommand
        {
            public void Execute(string query)
            {
                Console.WriteLine($"Sql Server executing command: {query}");
            }
        }

        public class SqlServerConnection : IConnection
        {
            public void OpenConnection()
            {
                Console.WriteLine("Sql Server connection opened.");
            }
        }

        // Concrete Products for Oracle
        public class OracleCommand : ICommand
        {
            public void Execute(string query)
            {
                Console.WriteLine($"Oracle executing command: {query}");
            }
        }

        public class OracleConnection : IConnection
        {
            public void OpenConnection()
            {
                Console.WriteLine("Oracle connection opened.");
            }
        }

        // Abstract Factory
        public interface IDatabaseFactory
        {
            ICommand CreateCommand();
            IConnection CreateConnection();
        }

        // Concrete Factories
        public class SqlServerFactory : IDatabaseFactory
        {
            public ICommand CreateCommand() => new SqlServerCommand();
            public IConnection CreateConnection() => new SqlServerConnection();
        }

        public class OracleFactory : IDatabaseFactory
        {
            public ICommand CreateCommand() => new OracleCommand();
            public IConnection CreateConnection() => new OracleConnection();
        }

        // Client Code
        public class DatabaseManager
        {
            private readonly ICommand _command;
            private readonly IConnection _connection;

            public DatabaseManager(IDatabaseFactory factory)
            {
                _command = factory.CreateCommand();
                _connection = factory.CreateConnection();
            }

            public void PerformDatabaseOperations(string query)
            {
                _connection.OpenConnection();
                _command.Execute(query);
            }
        }

        public void Test()
        {
            Console.WriteLine("Using Sql Server:");
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
