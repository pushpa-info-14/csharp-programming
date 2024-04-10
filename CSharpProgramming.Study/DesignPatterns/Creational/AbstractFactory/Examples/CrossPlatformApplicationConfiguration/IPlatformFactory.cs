namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public interface IPlatformFactory
{
    INotificationService CreateNotificationService();
    ISettings CreateSettings();
}