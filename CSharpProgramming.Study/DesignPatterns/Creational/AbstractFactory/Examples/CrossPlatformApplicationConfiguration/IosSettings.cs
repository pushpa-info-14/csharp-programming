namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class IosSettings : ISettings
{
    public string GetSetting(string key)
    {
        return $"iOS setting value for {key}";
    }
}