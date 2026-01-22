namespace CSharpProgramming.Study.BroCode
{
	public class Lesson35Inheritance
	{
		public void Method1()
		{
			// inheritance - 1 or more classes receiving fields, methods, etc. from a common parent

			var car = new Car();
			var bicycle = new Bicycle();
			var boat = new Boat();

			Console.WriteLine(car.Speed);
			Console.WriteLine(car.Wheels);
			car.Go();

			Console.WriteLine(bicycle.Speed);
			Console.WriteLine(bicycle.Wheels);
			bicycle.Go();

			Console.WriteLine(boat.Speed);
			Console.WriteLine(boat.Wheels);
			boat.Go();
		}

		class Vehicle
		{
			public int Speed = 0;

			public void Go()
			{
				Console.WriteLine("This vehicle is moving!");
			}
		}

		class Car : Vehicle
		{
			public int Wheels = 4;
		}

		class Bicycle : Vehicle
		{
			public int Wheels = 2;
		}

		class Boat : Vehicle
		{
			public int Wheels = 0;
		}
	}
}
