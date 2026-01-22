namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;

public class VehicleManufacturingPlantProgram
{
	// Abstract Products
	public interface IEngine
	{
		string GetEngineType();
	}

	public interface ITire
	{
		string GetTireType();
	}

	// Concrete Products for Electric Car
	public class ElectricCarEngine : IEngine
	{
		public string GetEngineType()
		{
			return "Electric Car Engine";
		}
	}

	public class ElectricCarTire : ITire
	{
		public string GetTireType()
		{
			return "Electric Car Tire";
		}
	}

	// Concrete Products for Gas Car
	public class GasCarEngine : IEngine
	{
		public string GetEngineType()
		{
			return "Gas Car Engine";
		}
	}

	public class GasCarTire : ITire
	{
		public string GetTireType()
		{
			return "Gas Car Tire";
		}
	}

	// Concrete Products for Electric Truck
	public class ElectricTruckEngine : IEngine
	{
		public string GetEngineType()
		{
			return "Electric Truck Engine";
		}
	}

	public class ElectricTruckTire : ITire
	{
		public string GetTireType()
		{
			return "Electric Truck Tire";
		}
	}

	// Concrete Products for Gas Truck
	public class GasTruckEngine : IEngine
	{
		public string GetEngineType()
		{
			return "Gas Truck Engine";
		}
	}

	public class GasTruckTire : ITire
	{
		public string GetTireType()
		{
			return "Gas Truck Tire";
		}
	}

	// Abstract Factory
	public interface IVehicleFactory
	{
		IEngine CreateEngine();

		ITire CreateTire();
	}

	// Concrete Factories
	public class ElectricCarFactory : IVehicleFactory
	{
		public IEngine CreateEngine() => new ElectricCarEngine();

		public ITire CreateTire() => new ElectricCarTire();
	}

	public class GasCarFactory : IVehicleFactory
	{
		public IEngine CreateEngine() => new GasCarEngine();

		public ITire CreateTire() => new GasCarTire();
	}

	public class ElectricTruckFactory : IVehicleFactory
	{
		public IEngine CreateEngine() => new ElectricTruckEngine();

		public ITire CreateTire() => new ElectricTruckTire();
	}

	public class GasTruckFactory : IVehicleFactory
	{
		public IEngine CreateEngine() => new GasTruckEngine();

		public ITire CreateTire() => new GasTruckTire();
	}

	// Client Code
	public class VehicleManufacturingPlant
	{
		private readonly IEngine _engine;
		private readonly ITire _tire;

		public VehicleManufacturingPlant(IVehicleFactory factory)
		{
			_engine = factory.CreateEngine();
			_tire = factory.CreateTire();
		}

		public void DescribeVehicle()
		{
			Console.WriteLine($"Vehicle with Engine: {_engine.GetEngineType()} and Tire: {_tire.GetTireType()}");
		}
	}

	public static void Test()
	{
		var gasCarFactory = new GasCarFactory();
		var gasCarPlant = new VehicleManufacturingPlant(gasCarFactory);
		gasCarPlant.DescribeVehicle();

		var electricCarFactory = new ElectricCarFactory();
		var electricCarPlant = new VehicleManufacturingPlant(electricCarFactory);
		electricCarPlant.DescribeVehicle();

		var gasTruckFactory = new GasTruckFactory();
		var gasTruckPlant = new VehicleManufacturingPlant(gasTruckFactory);
		gasTruckPlant.DescribeVehicle();

		var electricTruckFactory = new ElectricTruckFactory();
		var electricTruckPlant = new VehicleManufacturingPlant(electricTruckFactory);
		electricTruckPlant.DescribeVehicle();
	}
}
