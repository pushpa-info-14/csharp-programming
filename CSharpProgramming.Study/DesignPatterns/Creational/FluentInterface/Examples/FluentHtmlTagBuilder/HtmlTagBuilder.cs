namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentHtmlTagBuilder;

public class HtmlTagBuilder
{
    private readonly string _tagName;
    private string? _content;
    private readonly Dictionary<string, string> _attributes = new();

    public HtmlTagBuilder(string tagName)
    {
        _tagName = tagName;
    }

    public HtmlTagBuilder WithContent(string content)
    {
        _content = content;
        return this;
    }

    public HtmlTagBuilder AddAttribute(string attribute, string value)
    {
        _attributes[attribute] = value;
        return this;
    }

    public override string ToString()
    {
        var attributes = string.Join(" ", _attributes.Select(a => $"{a.Key}='{a.Value}'"));
        return $"<{_tagName} {attributes}>{_content}</{_tagName}>";
    }
}