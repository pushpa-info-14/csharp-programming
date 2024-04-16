namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentGameCharacterBuilder
{
    public class GameCharacterBuilderProgram
    {
        public void Test()
        {
            var hero = new CharacterBuilder()
                .Named("Aragorn")
                .WithHealth(100)
                .Wielding("Sword")
                .WithSkill("Leadership")
                .WithSkill("Swordsmanship")
                .Build();
            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"Weapon: {hero.Weapon}");
            Console.WriteLine($"Skills: {string.Join(", ", hero.Skills)}");
            // Outputs:
            // Name: Aragorn
            // Weapon: Sword
            // Skills: Leadership, Swordsmanship
        }
    }
}
