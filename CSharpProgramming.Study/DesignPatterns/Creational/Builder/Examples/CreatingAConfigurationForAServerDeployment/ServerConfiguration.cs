namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment;

public class ServerConfiguration
{
    public string? OperatingSystem { get; set; }
    public string? ServerType { get; set; }  // e.g., Web, Database, Cache
    public string? Database { get; set; }    // Optional: Database software
    public List<string> Middleware { get; set; } = new();
    public bool HasFirewall { get; set; }

    public void DisplayConfig()
    {
        Console.WriteLine($"OS: {OperatingSystem}");
        Console.WriteLine($"Server Type: {ServerType}");
        Console.WriteLine($"Database: {Database ?? "None"}");
        Console.WriteLine($"Middleware: {string.Join(", ", Middleware)}");
        Console.WriteLine($"Firewall: {(HasFirewall ? "Enabled" : "Disabled")}");
    }
}