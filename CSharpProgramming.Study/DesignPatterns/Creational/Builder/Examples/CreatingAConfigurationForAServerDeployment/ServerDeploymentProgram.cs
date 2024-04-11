namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment
{
    public class ServerDeploymentProgram
    {
        public void Test()
        {
            var deployment = new ServerDeployment();
            var webServerBuilder = new WebServerBuilder();

            deployment.Deploy(webServerBuilder);

            var serverConfig = webServerBuilder.GetConfiguration();
            serverConfig.DisplayConfig();
        }
    }
}
