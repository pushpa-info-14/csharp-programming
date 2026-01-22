namespace CSharpProgramming.Study.DesignPatterns.Structural.Flyweight;

public class VehicleLicensePlateManagementSystemProgram
{
	// Flyweight: LicensePlatePrefix holds the shared properties
	public class LicensePlatePrefix
	{
		public string StateOrRegion { get; }

		public LicensePlatePrefix(string stateOrRegion)
		{
			StateOrRegion = stateOrRegion;
		}

		public void DisplayPrefix()
		{
			Console.WriteLine($"Prefix: {StateOrRegion}");
		}
	}

	// Flyweight Factory
	public class PrefixFactory
	{
		private readonly Dictionary<string, LicensePlatePrefix> _prefixes = new();

		public LicensePlatePrefix GetPrefix(string stateOrRegion)
		{
			if (!_prefixes.ContainsKey(stateOrRegion))
			{
				_prefixes[stateOrRegion] = new LicensePlatePrefix(stateOrRegion);
			}

			return _prefixes[stateOrRegion];
		}
	}

	// The ConcreteFlyweight class with external states.
	public class LicensePlate
	{
		private readonly LicensePlatePrefix _prefix;
		public int UniqueNumber { get; }

		public LicensePlate(int uniqueNumber, LicensePlatePrefix prefix)
		{
			UniqueNumber = uniqueNumber;
			_prefix = prefix;
		}

		public void DisplayPlate()
		{
			_prefix.DisplayPrefix();
			Console.WriteLine($"Unique Number: {UniqueNumber}");
		}
	}

	// Client
	class LicensePlateSystem
	{
		private readonly List<LicensePlate> _plates = new();
		private readonly PrefixFactory _prefixFactory = new();

		public void RegisterVehicle(string stateOrRegion, int uniqueNumber)
		{
			var prefix = _prefixFactory.GetPrefix(stateOrRegion);
			_plates.Add(new LicensePlate(uniqueNumber, prefix));
		}

		public void DisplayAllPlates()
		{
			foreach (var plate in _plates)
			{
				plate.DisplayPlate();
				Console.WriteLine("-----");
			}
		}
	}

	public void Test()
	{
		var plateSystem = new LicensePlateSystem();

		plateSystem.RegisterVehicle("NY", 12345);
		plateSystem.RegisterVehicle("CA", 67890);
		plateSystem.RegisterVehicle("NY", 54321);

		plateSystem.DisplayAllPlates();
	}
}
