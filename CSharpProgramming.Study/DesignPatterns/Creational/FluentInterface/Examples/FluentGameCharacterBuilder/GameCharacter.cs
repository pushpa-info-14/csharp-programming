namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentGameCharacterBuilder;

public class GameCharacter
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public string? Weapon { get; set; }
    public List<string> Skills { get; } = new();
}