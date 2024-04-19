namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class ServiceProxies
    {
        public interface IDataService
        {
            string GetData();
        }

        // Simulated remote service proxy
        public sealed class DataServiceProxy : IDataService
        {
            // Static instance for Singleton
            private static readonly Lazy<DataServiceProxy> Instance = new(() => new DataServiceProxy());

            private DataServiceProxy()
            {
                // Initialization, perhaps establishing a connection to the remote service
            }

            public string GetData()
            {
                // Simulating a call to a remote service
                // In a real scenario, this would involve making an actual network request 
                // to retrieve the data.
                return "Data from remote service";
            }

            // Public property to access the Singleton instance
            public static DataServiceProxy GetInstance()
            {
                return Instance.Value;
            }
        }

        // Client Code
        public void Test()
        {
            // Usage:
            IDataService dataService = DataServiceProxy.GetInstance();
            var data = dataService.GetData();
            Console.WriteLine(data);
        }
    }
}
