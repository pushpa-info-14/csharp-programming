namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O3_AbstractFactory.Examples;

public class FurnitureShopProgram
{
	// Abstract Products
	public interface IChair
	{
		void SitOn();
	}

	public interface ISofa
	{
		void LayOn();
	}

	// Concrete Products for Modern Style
	public class ModernChair : IChair
	{
		public void SitOn()
		{
			Console.WriteLine("Sitting on a modern chair.");
		}
	}

	public class ModernSofa : ISofa
	{
		public void LayOn()
		{
			Console.WriteLine("Laying on a modern sofa.");
		}
	}

	// Concrete Products for Vintage Style
	public class VintageChair : IChair
	{
		public void SitOn()
		{
			Console.WriteLine("Sitting on a vintage chair.");
		}
	}

	public class VintageSofa : ISofa
	{
		public void LayOn()
		{
			Console.WriteLine("Laying on a vintage sofa.");
		}
	}

	// Abstract Factory
	public interface IFurnitureFactory
	{
		IChair CreateChair();

		ISofa CreateSofa();
	}

	// Concrete Factories
	public class ModernFurnitureFactory : IFurnitureFactory
	{
		public IChair CreateChair() => new ModernChair();

		public ISofa CreateSofa() => new ModernSofa();
	}

	public class VintageFurnitureFactory : IFurnitureFactory
	{
		public IChair CreateChair() => new VintageChair();

		public ISofa CreateSofa() => new VintageSofa();
	}

	// Client Code
	public class FurnitureShop
	{
		private readonly IChair _chair;
		private readonly ISofa _sofa;

		public FurnitureShop(IFurnitureFactory factory)
		{
			_chair = factory.CreateChair();
			_sofa = factory.CreateSofa();
		}

		public void ShowProducts()
		{
			_chair.SitOn();
			_sofa.LayOn();
		}
	}

	public static void Test()
	{
		Console.WriteLine("Order for Modern Furniture:");
		var modernFactory = new ModernFurnitureFactory();
		var modernShop = new FurnitureShop(modernFactory);
		modernShop.ShowProducts();

		Console.WriteLine("Order for Vintage Furniture:");
		var vintageFactory = new VintageFurnitureFactory();
		var vintageShop = new FurnitureShop(vintageFactory);
		vintageShop.ShowProducts();
	}
}
