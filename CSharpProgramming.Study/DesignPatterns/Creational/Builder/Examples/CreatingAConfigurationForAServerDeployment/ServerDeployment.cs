namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment;

public class ServerDeployment
{
    public void Deploy(ServerBuilder builder)
    {
        builder.SetOperatingSystem();
        builder.SetServerType();
        builder.InstallDatabase();
        builder.InstallMiddleware();
        builder.EnableFirewall();
    }
}