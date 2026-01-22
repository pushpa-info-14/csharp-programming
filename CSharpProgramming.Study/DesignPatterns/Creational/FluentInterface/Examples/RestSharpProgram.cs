using System.Net.Http.Json;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples;

public class RestSharpProgram
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		//... Other properties
	}

	public static async Task TestAsync()
	{
		using var client = new HttpClient
		{
			BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
		};

		int id = 1;

		HttpResponseMessage response = await client.GetAsync($"users/{id}");

		if (response.IsSuccessStatusCode)
		{
			User? user = await response.Content.ReadFromJsonAsync<User>();

			if (user != null)
			{
				Console.WriteLine($"User ID: {user.Id}, User Name: {user.Name}");
			}
		}
		else
		{
			Console.WriteLine($"Error: {(int)response.StatusCode} - {response.ReasonPhrase}");
		}
	}
}
