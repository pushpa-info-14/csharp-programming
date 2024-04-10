namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration
{
    public class ApplicationConfiguratorProgram
    {
        public void Test()
        {
            IPlatformFactory platformFactory;

            if (Environment.OSVersion.Platform == PlatformID.Unix) // A simplistic way to distinguish, not accurate for all scenarios
            {
                platformFactory = new IosFactory();
            }
            else
            {
                platformFactory = new AndroidFactory();
            }

            var appConfigurator = new ApplicationConfigurator(platformFactory);
            appConfigurator.RunSampleOperations();
        }
    }
}
