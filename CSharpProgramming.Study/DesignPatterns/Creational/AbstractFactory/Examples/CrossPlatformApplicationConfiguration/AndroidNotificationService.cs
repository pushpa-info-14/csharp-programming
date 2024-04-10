namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class AndroidNotificationService : INotificationService
{
    public void Notify(string message)
    {
        Console.WriteLine($"Android notification: {message}");
    }
}