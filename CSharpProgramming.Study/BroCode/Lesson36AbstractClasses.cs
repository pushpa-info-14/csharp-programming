namespace CSharpProgramming.Study.BroCode
{
	public class Lesson36AbstractClasses
	{
		public void Method1()
		{
			// abstract classes - Modifier that indicates missing components or incomplete implementation

			// var vehicle = new Vehicle(); // You cannot
			var car = new Car();
			var bicycle = new Bicycle();
			var boat = new Boat();
		}

		abstract class Vehicle
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
