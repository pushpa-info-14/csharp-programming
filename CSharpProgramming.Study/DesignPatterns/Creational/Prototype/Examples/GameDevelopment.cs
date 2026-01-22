namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples;

public class GameDevelopment
{
	// Prototype - ICreaturePrototype Interface
	public interface ICreaturePrototype
	{
		ICreaturePrototype Clone();
	}

	// Concrete Prototype - Creature Class
	public class Creature : ICreaturePrototype
	{
		public string Type { get; set; }

		public int BaseHealth { get; set; }

		public int BaseAttack { get; set; }

		public string Color { get; set; }

		public ICreaturePrototype Clone()
		{
			return new Creature
			{
				Type = Type,
				BaseHealth = BaseHealth,
				BaseAttack = BaseAttack,
				Color = Color
			};
		}

		public void DisplayStats()
		{
			Console.WriteLine($"{Type} | Health: {BaseHealth} | Attack: {BaseAttack} | Color: {Color}");
		}
	}

	// Client Code
	public static void Test()
	{
		// Base creature prototype loaded from the game database
		var dragonPrototype = new Creature
		{
			Type = "Dragon",
			BaseHealth = 100,
			BaseAttack = 50,
			Color = "Red"
		};

		Console.WriteLine("Dragon Prototype:");
		dragonPrototype.DisplayStats();

		// Player deploys a dragon in battle, but there's a 10% health bonus in this battle
		var battleDragon = (Creature)dragonPrototype.Clone();
		battleDragon.BaseHealth = (int)(battleDragon.BaseHealth * 1.1); // 10% bonus

		Console.WriteLine("\nBattle Dragon with Health Bonus:");
		battleDragon.DisplayStats();
	}
}
