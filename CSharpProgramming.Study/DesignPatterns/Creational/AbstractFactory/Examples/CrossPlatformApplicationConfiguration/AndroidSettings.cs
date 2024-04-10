namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;

public class AndroidSettings : ISettings
{
    public string GetSetting(string key)
    {
        return $"Android setting value for {key}";
    }
}