namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentUserProfileBuilder;

public class UserProfile
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Bio { get; set; }
    public List<string> Interests { get; } = new();
    public Dictionary<string, string> SocialLinks { get; } = new();
}