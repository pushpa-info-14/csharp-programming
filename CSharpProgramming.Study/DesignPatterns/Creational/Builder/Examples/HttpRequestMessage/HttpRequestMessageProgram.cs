using System.Text;

namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.HttpRequestMessage
{
    public class HttpRequestMessageProgram
    {
        public void Test()
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
}
