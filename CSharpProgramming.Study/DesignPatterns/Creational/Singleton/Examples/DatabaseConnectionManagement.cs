using System.Data.SqlClient;

namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class DatabaseConnectionManagement
    {
        public sealed class DatabaseConnectionManager
        {
            // Static variable to hold the single instance of the class
            private static readonly DatabaseConnectionManager Instance = new();

            // SqlConnection object
            private readonly SqlConnection _connection;

            // Private constructor to prevent external instantiation
            private DatabaseConnectionManager()
            {
                // Initialize the SqlConnection object here. For simplicity, connection string is hardcoded.
                _connection = new SqlConnection("YourConnectionStringHere");
            }

            // Public property to access the single instance
            public static DatabaseConnectionManager GetInstance()
            {
                return Instance;
            }

            // Method to open the connection
            public void OpenConnection()
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }

            // Method to close the connection
            public void CloseConnection()
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            // Method to get the SqlConnection object for executing commands
            public SqlConnection GetConnection()
            {
                return _connection;
            }
        }

        // Client Code
        public void Test()
        {
            DatabaseConnectionManager.GetInstance().OpenConnection();
            var command = new SqlCommand("Your SQL Query Here", DatabaseConnectionManager.GetInstance().GetConnection());
            // ... Execute command ...

            DatabaseConnectionManager.GetInstance().CloseConnection();
        }
    }
}
