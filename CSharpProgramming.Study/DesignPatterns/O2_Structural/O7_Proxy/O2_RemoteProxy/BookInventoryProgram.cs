namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O2_RemoteProxy;

public class BookInventoryProgram
{
	// Subject Interface:
	// This is the common interface that both the real subject and the proxy will implement.
	public interface IBookInventory
	{
		int GetAvailableCopies(string isbn);
	}

	// Real Subject (remote system):
	// Although you typically wouldn't have direct access to the real subject in a remote proxy setup, 
	// for the sake of understanding, let's visualize the real system:
	// This represents the actual remote inventory system
	public class RemoteBookInventory : IBookInventory
	{
		public int GetAvailableCopies(string isbn)
		{
			// Logic to retrieve book information from a remote database
			// For simplicity, let's assume a hard-coded value.
			return 10;
		}
	}

	// Remote Proxy:
	// This is the local representative for the remote service.
	public class BookInventoryProxy : IBookInventory
	{
		private readonly HttpClient _httpClient;
		private const string serviceUrl = "https://remotebookinventory.com/api";

		public BookInventoryProxy()
		{
			_httpClient = new HttpClient();
		}

		public int GetAvailableCopies(string isbn)
		{
			var response = _httpClient.GetStringAsync($"{serviceUrl}/availableCopies?isbn={isbn}").Result;
			return int.Parse(response);
		}
	}

	public static void Test()
	{
		var bookInventory = new BookInventoryProxy();
		int availableCopies = bookInventory.GetAvailableCopies("978-3-16-148410-0");
		Console.WriteLine($"Available copies for ISBN 978-3-16-148410-0: {availableCopies}");
	}
}
