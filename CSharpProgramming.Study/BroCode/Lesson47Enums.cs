namespace CSharpProgramming.Study.BroCode
{
	public class Lesson47Enums
	{
		public void Method1()
		{
			// enums - Special "class" that contains a set of named integer constants.
			//         Use enums when you have values that you know will not change.
			//         To get the integer value from an item, you must explicitly convert to an int.

			Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
			Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);

			Console.WriteLine("Planet: " + PlanetRadius.Earth);
			Console.WriteLine("Radius: " + (int)PlanetRadius.Earth + "km");
			Console.WriteLine("Volume: " + Volume(PlanetRadius.Earth) + "km^3");
		}

		private double Volume(PlanetRadius radius)
		{
			return (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
		}

		enum Planets
		{
			Mercury = 1,
			Venus = 2,
			Earth = 3,
			Mars = 4,
			Jupiter = 5,
			Saturn = 6,
			Uranus = 7,
			Neptune = 8,
			Pluto = 9
		}

		enum PlanetRadius
		{
			Mercury = 2439,
			Venus = 6051,
			Earth = 6371,
			Mars = 3389,
			Jupiter = 69911,
			Saturn = 58232,
			Uranus = 25362,
			Neptune = 24622,
			Pluto = 1188
		}
	}
}
