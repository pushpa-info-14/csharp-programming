namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class DataSharing
    {
        public sealed class InMemoryCache
        {
            // Static instance for Singleton
            private static readonly Lazy<InMemoryCache> Instance = new(() => new InMemoryCache());

            // Dictionary to hold cached data
            private readonly Dictionary<string, object> _cacheStore;

            // Private constructor to prevent external instantiation
            private InMemoryCache()
            {
                _cacheStore = new Dictionary<string, object>();
            }

            // Public method to add or update an item in the cache
            public void AddOrUpdate(string key, object data)
            {
                _cacheStore[key] = data;
            }

            // Public method to retrieve an item from the cache
            public object Get(string key)
            {
                _cacheStore.TryGetValue(key, out var data);
                return data;
            }

            // Public method to remove an item from the cache
            public void Remove(string key)
            {
                if (_cacheStore.ContainsKey(key))
                {
                    _cacheStore.Remove(key);
                }
            }

            // Public property to access the Singleton instance
            public static InMemoryCache GetInstance()
            {
                return Instance.Value;
            }
        }

        // Client Code
        public void Test()
        {
            // Usage:
            // Store data in the cache
            InMemoryCache.GetInstance().AddOrUpdate("UserData", "someUserDataObject");

            // Retrieve data from the cache
            var cachedData = InMemoryCache.GetInstance().Get("UserData");

            // Remove data from the cache
            InMemoryCache.GetInstance().Remove("UserData");
        }
    }
}
