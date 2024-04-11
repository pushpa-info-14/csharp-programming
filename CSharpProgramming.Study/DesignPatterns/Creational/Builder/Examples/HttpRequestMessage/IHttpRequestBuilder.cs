namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.HttpRequestMessage;

public interface IHttpRequestBuilder
{
    IHttpRequestBuilder WithMethod(HttpMethod method);
    IHttpRequestBuilder WithUri(Uri uri);
    IHttpRequestBuilder WithContent(HttpContent content);
    IHttpRequestBuilder WithHeader(string name, string value);
    System.Net.Http.HttpRequestMessage Build();
}