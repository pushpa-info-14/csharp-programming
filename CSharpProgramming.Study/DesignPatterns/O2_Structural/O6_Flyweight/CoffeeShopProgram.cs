namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O6_Flyweight;

public class CoffeeShopProgram
{
	// Flyweight
	public class Coffee
	{
		public string Flavor { get; private set; }
		public string Ingredients { get; private set; }
		public string Preparation { get; private set; }
		public Coffee(string flavor, string ingredients, string preparation)
		{
			Flavor = flavor;
			Ingredients = ingredients;
			Preparation = preparation;
		}
		public void ServeCoffee(int tableNumber, string customizations = "")
		{
			Console.WriteLine($"Serving {Flavor} coffee (made with {Ingredients} and {Preparation}) to table {tableNumber}. {customizations}");
		}
	}

	// Flyweight Factory
	public class CoffeeFactory
	{
		private readonly Dictionary<string, Coffee> _coffees = new Dictionary<string, Coffee>();
		public Coffee GetCoffee(string flavor)
		{
			if (!_coffees.ContainsKey(flavor))
			{
				// For simplicity, let's assume every coffee just has water as its ingredient and is brewed.
				var coffee = new Coffee(flavor, "water", "brewed");
				_coffees.Add(flavor, coffee);
			}
			return _coffees[flavor];
		}
	}

	// Client
	public class CoffeeShop
	{
		private readonly CoffeeFactory _coffeeFactory = new();
		private readonly List<Tuple<Coffee, int, string>> _orders = new();

		public void TakeOrder(string flavor, int tableNumber, string customizations = "")
		{
			var coffee = _coffeeFactory.GetCoffee(flavor);
			_orders.Add(Tuple.Create(coffee, tableNumber, customizations));
		}

		public void ServeOrders()
		{
			foreach (var order in _orders)
			{
				order.Item1.ServeCoffee(order.Item2, order.Item3);
			}
			_orders.Clear();  // Once served, clear the orders
		}
	}

	public void Test()
	{
		var shop = new CoffeeShop();
		shop.TakeOrder("Cappuccino", 1);
		shop.TakeOrder("Espresso", 2, "With extra sugar");
		shop.TakeOrder("Cappuccino", 3);
		shop.TakeOrder("Latte", 4);
		shop.ServeOrders();
	}
}
