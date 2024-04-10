namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class ApplicationConfigurator
{
    private readonly INotificationService _notificationService;
    private readonly ISettings _settings;

    public ApplicationConfigurator(IPlatformFactory factory)
    {
        _notificationService = factory.CreateNotificationService();
        _settings = factory.CreateSettings();
    }

    public void RunSampleOperations()
    {
        string usernameSetting = _settings.GetSetting("Username");
        Console.WriteLine($"Retrieved setting: {usernameSetting}");

        _notificationService.Notify("App started!");
    }
}