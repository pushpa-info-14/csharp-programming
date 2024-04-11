namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment;

public abstract class ServerBuilder
{
    protected ServerConfiguration Configuration { get; } = new();

    public abstract void SetOperatingSystem();
    public abstract void SetServerType();
    public abstract void InstallDatabase();
    public abstract void InstallMiddleware();
    public abstract void EnableFirewall();

    public ServerConfiguration GetConfiguration() => Configuration;
}