namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentEmailBuilder;

public class EmailBuilder
{
    private readonly Email _email = new();

    public EmailBuilder From(string sender)
    {
        _email.From = sender;
        return this;
    }

    public EmailBuilder To(string recipient)
    {
        _email.To.Add(recipient);
        return this;
    }

    public EmailBuilder WithSubject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public EmailBuilder WithBody(string body)
    {
        _email.Body = body;
        return this;
    }

    public Email Send()  // This would be integrated with an actual sending mechanism in a real-world scenario.
    {
        // Logic to send the email...
        Console.WriteLine($"Sent email to {string.Join(", ", _email.To)} with subject '{_email.Subject}'.");
        return _email;
    }
}