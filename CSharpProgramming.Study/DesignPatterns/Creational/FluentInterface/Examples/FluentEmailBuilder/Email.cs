namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentEmailBuilder;

public class Email
{
    public string From { get; set; }
    public List<string> To { get; } = new();
    public string Subject { get; set; }
    public string Body { get; set; }
    // ... Additional fields like CC, BCC, Attachments, etc.
}