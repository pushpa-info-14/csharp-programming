namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples
{
    public class GameCharacterBuilderProgram
    {
        public class GameCharacter
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public string Weapon { get; set; }
            public List<string> Skills { get; } = new();
        }

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
