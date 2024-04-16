namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentGameCharacterBuilder;

public class CharacterBuilder
{
    private readonly GameCharacter _character = new();

    public CharacterBuilder Named(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder WithHealth(int health)
    {
        _character.Health = health;
        return this;
    }

    public CharacterBuilder Wielding(string weapon)
    {
        _character.Weapon = weapon;
        return this;
    }

    public CharacterBuilder WithSkill(string skill)
    {
        _character.Skills.Add(skill);
        return this;
    }

    public GameCharacter Build()
    {
        return _character;
    }
}