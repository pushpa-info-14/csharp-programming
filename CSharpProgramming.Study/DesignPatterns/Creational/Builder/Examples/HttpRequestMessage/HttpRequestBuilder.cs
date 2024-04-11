namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.HttpRequestMessage;

public class HttpRequestBuilder : IHttpRequestBuilder
{
    private HttpMethod? _method;
    private Uri? _uri;
    private HttpContent? _content;
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

    public System.Net.Http.HttpRequestMessage Build()
    {
        var message = new System.Net.Http.HttpRequestMessage(_method!, _uri)
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