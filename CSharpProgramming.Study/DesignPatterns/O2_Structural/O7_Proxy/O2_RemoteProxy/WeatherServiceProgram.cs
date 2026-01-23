namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O2_RemoteProxy;

public class WeatherServiceProgram
{
	// Subject Interface
	public interface IWeatherService
	{
		string GetCurrentWeather(string city);
	}

	// Remote Proxy:
	// This will interact with the remote weather service using an HTTP client.
	public class WeatherServiceProxy : IWeatherService
	{
		private readonly HttpClient _httpClient;
		private const string baseUrl = "https://weatherapi.example.com";

		public WeatherServiceProxy()
		{
			_httpClient = new HttpClient();
		}

		public string GetCurrentWeather(string city)
		{
			var response = _httpClient.GetStringAsync($"{baseUrl}/current?city={city}").Result;
			return response; // This might return a JSON string which can be further deserialized.
		}
	}

	public static void Test()
	{
		var weatherService = new WeatherServiceProxy();
		string weather = weatherService.GetCurrentWeather("London");
		Console.WriteLine($"Current weather in London: {weather}");
	}
}
