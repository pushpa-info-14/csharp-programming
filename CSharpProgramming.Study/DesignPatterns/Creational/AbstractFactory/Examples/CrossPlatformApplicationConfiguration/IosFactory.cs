namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class IosFactory : IPlatformFactory
{
    public INotificationService CreateNotificationService() => new IosNotificationService();
    public ISettings CreateSettings() => new IosSettings();
}