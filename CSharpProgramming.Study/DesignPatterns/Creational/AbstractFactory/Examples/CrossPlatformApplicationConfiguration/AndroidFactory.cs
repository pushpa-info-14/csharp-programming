namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class AndroidFactory : IPlatformFactory
{
    public INotificationService CreateNotificationService() => new AndroidNotificationService();
    public ISettings CreateSettings() => new AndroidSettings();
}