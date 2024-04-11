namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment;

public class WebServerBuilder : ServerBuilder
{
    public override void SetOperatingSystem()
    {
        Configuration.OperatingSystem = "Linux";
    }

    public override void SetServerType()
    {
        Configuration.ServerType = "Web";
    }

    public override void InstallDatabase()
    {
        // For this web server, no DB installation
    }

    public override void InstallMiddleware()
    {
        Configuration.Middleware.Add("Nginx");
        Configuration.Middleware.Add("Node.js");
    }

    public override void EnableFirewall()
    {
        Configuration.HasFirewall = true;
    }
}