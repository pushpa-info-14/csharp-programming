namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class ServiceLocatorProgram
    {
        public sealed class ServiceLocator
        {
            // Static instance for Singleton
            private static readonly ServiceLocator Instance = new();

            // Dictionary to hold services
            private readonly Dictionary<Type, object> _services;

            // Private constructor to prevent external instantiation
            private ServiceLocator()
            {
                _services = new Dictionary<Type, object>();
            }

            // Public method to register a service
            public void RegisterService<T>(T service)
            {
                var type = typeof(T);
                if (!_services.ContainsKey(type))
                {
                    _services[type] = service;
                }
                else
                {
                    throw new ArgumentException($"Service of type {type.FullName} is already registered.");
                }
            }

            // Public method to get a service
            public T GetService<T>()
            {
                var type = typeof(T);
                if (_services.TryGetValue(type, out var service))
                {
                    return (T)service;
                }
                else
                {
                    throw new InvalidOperationException($"Service of type {type.FullName} is not registered.");
                }
            }

            // Public property to access the Singleton instance
            public static ServiceLocator GetInstance()
            {
                return Instance;
            }
        }

        // Define some service and interface
        public interface ILogger
        {
            void Log(string message);
        }

        public class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }

        // Client Code
        public void Test()
        {
            // Registering and using the service
            ServiceLocator.GetInstance().RegisterService<ILogger>(new ConsoleLogger());
            var logger = ServiceLocator.GetInstance().GetService<ILogger>();
            logger.Log("This is a test message.");
        }
    }
}
