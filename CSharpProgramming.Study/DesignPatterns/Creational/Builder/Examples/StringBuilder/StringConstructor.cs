namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.StringBuilder;

public class StringConstructor
{
    private readonly CustomString _customString = new();

    public StringConstructor AppendLine(string line)
    {
        _customString.Append(line + Environment.NewLine);
        return this;
    }

    public StringConstructor AppendSpace(string word)
    {
        _customString.Append(word + " ");
        return this;
    }

    public StringConstructor AppendWords(params string[] words)
    {
        foreach (var word in words)
        {
            AppendSpace(word);
        }
        return this;
    }

    public CustomString Build()
    {
        return _customString;
    }
}