namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.StringBuilder;

public class CustomString
{
    private readonly System.Text.StringBuilder _stringBuilder = new();

    public void Append(string str)
    {
        _stringBuilder.Append(str);
    }

    public override string ToString()
    {
        return _stringBuilder.ToString();
    }
}