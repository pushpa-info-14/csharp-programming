using System.Text;

namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O4_Builder.Examples;

public class HttpRequestMessageProgram
{
	public interface IHttpRequestBuilder
	{
		IHttpRequestBuilder WithMethod(HttpMethod method);

		IHttpRequestBuilder WithUri(Uri uri);

		IHttpRequestBuilder WithContent(HttpContent content);

		IHttpRequestBuilder WithHeader(string name, string value);

		HttpRequestMessage Build();
	}

	public class HttpRequestBuilder : IHttpRequestBuilder
	{
		private HttpMethod _method;
		private Uri _uri;
		private HttpContent _content;
		private readonly Dictionary<string, string> _headers = new();

		public IHttpRequestBuilder WithMethod(HttpMethod method)
		{
			_method = method;
			return this;
		}

		public IHttpRequestBuilder WithUri(Uri uri)
		{
			_uri = uri;
			return this;
		}

		public IHttpRequestBuilder WithContent(HttpContent content)
		{
			_content = content;
			return this;
		}

		public IHttpRequestBuilder WithHeader(string name, string value)
		{
			_headers[name] = value;
			return this;
		}

		public HttpRequestMessage Build()
		{
			var message = new HttpRequestMessage(_method!, _uri)
			{
				Content = _content
			};

			foreach (var header in _headers)
			{
				message.Headers.Add(header.Key, header.Value);
			}

			return message;
		}
	}

	public static void Test()
	{
		var request = new HttpRequestBuilder()
			.WithMethod(HttpMethod.Post)
			.WithUri(new Uri("https://api.example.com/items"))
			.WithContent(new StringContent("{\"name\":\"sampleItem\"}", Encoding.UTF8, "application/json"))
			.WithHeader("Authorization", "Bearer my_token")
			.Build();

		// You can now use this request with HttpClient to send the actual request.
		using var client = new HttpClient();
		var response = client.SendAsync(request).Result;

		Console.WriteLine(response.StatusCode);
	}
}
