using RestSharp;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples
{
    public class RestSharpProgram
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            //... Other properties
        }

        public void Test()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("users/{id}", Method.Get)
                .AddUrlSegment("id", 1);
            RestResponse<User> response = client.Execute<User>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"User ID: {response.Data!.Id}, User Name: {response.Data.Name}");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusDescription}");
            }
        }
    }
}
