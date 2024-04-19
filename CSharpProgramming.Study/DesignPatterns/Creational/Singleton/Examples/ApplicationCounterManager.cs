using System.Collections.Concurrent;

namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class ApplicationCounterManager
    {
        public sealed class AppCounterManager
        {
            // Static instance for Singleton
            private static readonly Lazy<AppCounterManager> Instance = new(() => new AppCounterManager());

            // ConcurrentDictionary to hold counters; ensures thread-safety
            private readonly ConcurrentDictionary<string, long> _counters;

            // Private constructor to prevent external instantiation
            private AppCounterManager()
            {
                _counters = new ConcurrentDictionary<string, long>();
            }

            // Public method to increment a specific counter
            public void IncrementCounter(string counterName)
            {
                _counters.AddOrUpdate(counterName, 1, (_, currentValue) => currentValue + 1);
            }

            // Public method to get the value of a specific counter
            public long GetCounterValue(string counterName)
            {
                return _counters.TryGetValue(counterName, out var value) ? value : 0;
            }

            // Public property to access the Singleton instance
            public static AppCounterManager GetInstance()
            {
                return Instance.Value;
            }
        }

        // Client Code
        public void Test()
        {
            // Usage:
            // Increment the "UserLogins" counter
            AppCounterManager.GetInstance().IncrementCounter("UserLogins");
            AppCounterManager.GetInstance().IncrementCounter("UserLogins");
            AppCounterManager.GetInstance().IncrementCounter("UserLogins");

            // Retrieve the current value of the "UserLogins" counter
            var currentLogins = AppCounterManager.GetInstance().GetCounterValue("UserLogins");
            Console.WriteLine(currentLogins);
        }
    }
}
