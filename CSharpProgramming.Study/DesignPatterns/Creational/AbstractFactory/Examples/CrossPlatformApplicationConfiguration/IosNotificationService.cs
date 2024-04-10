namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class IosNotificationService : INotificationService
{
    public void Notify(string message)
    {
        Console.WriteLine($"iOS notification: {message}");
    }
}