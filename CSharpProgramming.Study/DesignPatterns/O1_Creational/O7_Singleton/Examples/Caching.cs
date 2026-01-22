using System.Collections.Concurrent;

namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O7_Singleton.Examples;

public class Caching
{
	// Declaring the Interface for Cache Operations
	// This Interface is going to be Implemented by Singleton Class
	public interface IMyCache
	{
		bool Add(object key, object value);

		bool AddOrUpdate(object key, object value);

		object Get(object key);

		bool Remove(object key);

		void Clear();
	}

	public sealed class SingletonCache : IMyCache
	{
		// Shared resource that needs protection in a Multi-threaded Environment
		// ConcurrentDictionary Collection is Thread-Safe
		private readonly ConcurrentDictionary<object, object> _concurrentDictionary = new();

		// This variable is going to store the Singleton Instance
		// Initializing the Variable at the time of class start-up 
		// and make it ready to be used in the Future
		private static readonly SingletonCache SingletonInstance = new();

		// The following Static Method is going to return the Singleton Instance
		// This is Thread-Safe as it uses Eager Loading
		public static SingletonCache GetInstance()
		{
			return SingletonInstance;
		}

		// Constructor needs to be Private in order to restrict 
		// class instantiation from Outside of this class
		private SingletonCache()
		{
			Console.WriteLine("SingletonCache Instance Created");
		}

		// The following methods can be accessed from outside of the class by using the Singleton Instance

		// This method is used to add a Key-Value Pair into the Cache
		public bool Add(object key, object value)
		{
			return _concurrentDictionary.TryAdd(key, value);
		}

		// This method is used to add or update a Key-Value Pair into the Cache
		// If the Key is not available then add the key-value pair
		// If the Key is already added, then update the value of that key
		public bool AddOrUpdate(object key, object value)
		{
			if (_concurrentDictionary.ContainsKey(key))
			{
				_concurrentDictionary.TryRemove(key, out _);
			}
			return _concurrentDictionary.TryAdd(key, value);
		}

		// This method is used to return the value of the given key if present in the cache
		// Else return null
		public object Get(object key)
		{
			if (_concurrentDictionary.TryGetValue(key, out var value))
			{
				return value;
			}
			return null;
		}

		// This method is used to remove the given key from the cache
		// If removed return true else return false
		public bool Remove(object key)
		{
			return _concurrentDictionary.TryRemove(key, out _);
		}

		// This method is used to remove the given key from the cache
		// If removed return true else return false
		public void Clear()
		{
			// Removes all keys and values from the ConcurrentDictionary i.e. from the Cache
			_concurrentDictionary.Clear();
		}
	}

	public static void Test()
	{
		// Get the SingletonCache Instance
		var cache = SingletonCache.GetInstance();
		// Adding Keys and Values into the Cache using Add and AddOrUpdate Method
		Console.WriteLine("Adding Keys and Values into Cache");
		Console.WriteLine($" Adding Id in Cache: {cache.Add("Id", 1001)}");
		Console.WriteLine($" Adding Name in Cache: {cache.Add("Name", "Pranaya")}");
		Console.WriteLine($" Adding Same Id Key in Cache using Add: {cache.Add("Id", 2001)}");
		Console.WriteLine($" Adding Same Id Key in Cache using AddOrUpdate: {cache.AddOrUpdate("Id", 2001)}");

		// Accessing values from Cache using Keys using the Get Method by passing the Keys
		Console.WriteLine("\nFetching Values from Cache");
		Console.WriteLine($" Fetching Id From Cache: {cache.Get("Id")}");
		Console.WriteLine($" Fetching Name From Cache: {cache.Get("Name")}");

		// Removing Elements from Cache using Remove Method by passing the given keys
		Console.WriteLine("\nRemoving Values from Cache");
		Console.WriteLine($" Remove Id: {cache.Remove("Id")}");
		Console.WriteLine($" Accessing Id From Cache: {cache.Get("Id")}");

		// Removing All Elements from the Cache using the Clear Method
		cache.Clear();
		Console.WriteLine("\nClearing All Keys and Values");
		Console.WriteLine($"Fetching Name From Cache: {cache.Get("Name")}");
	}
}
