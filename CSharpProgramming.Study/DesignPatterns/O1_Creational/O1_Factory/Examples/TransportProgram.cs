namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O1_Factory.Examples;

public class TransportProgram
{
	public interface ITransport
	{
		void StartRoute();
	}

	public class Car : ITransport
	{
		public void StartRoute()
		{
			Console.WriteLine("Starting the journey with a car!");
			// Logic related to starting a car route
		}
	}

	public class Bike : ITransport
	{
		public void StartRoute()
		{
			Console.WriteLine("Starting the journey with a bike!");
			// Logic related to starting a bike route
		}
	}

	public class Bus : ITransport
	{
		public void StartRoute()
		{
			Console.WriteLine("Starting the journey with a bus!");
			// Logic related to starting a bus route
		}
	}

	public static class TransportFactory
	{
		public static ITransport CreateTransport(string type)
		{
			switch (type.ToLower())
			{
				case "car":
					return new Car();
				case "bus":
					return new Bus();
				case "bike":
					return new Bike();
				default:
					throw new ArgumentException("Invalid transport type");
			}
		}
	}

	public static void Test()
	{
		var chosenTransport = TransportFactory.CreateTransport("car");
		chosenTransport.StartRoute();

		chosenTransport = TransportFactory.CreateTransport("bus");
		chosenTransport.StartRoute();

		chosenTransport = TransportFactory.CreateTransport("bike");
		chosenTransport.StartRoute();
	}
}
