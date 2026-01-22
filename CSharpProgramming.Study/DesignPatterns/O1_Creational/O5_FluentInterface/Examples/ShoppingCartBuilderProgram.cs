namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O5_FluentInterface.Examples;

public class ShoppingCartBuilderProgram
{
	public class Product
	{
		public string Name { get; set; }

		public decimal Price { get; set; }
	}

	public class Order
	{
		public List<Product> Products { get; } = new List<Product>();

		public decimal TotalPrice => Products.Sum(p => p.Price);

		public Order AddProduct(Product product)
		{
			Products.Add(product);
			return this;
		}

		public Order RemoveProduct(Product product)
		{
			Products.Remove(product);
			return this;
		}
	}

	public class ShoppingCartBuilder
	{
		private readonly Order _order = new();
		public ShoppingCartBuilder AddProduct(string name, decimal price)
		{
			var product = new Product { Name = name, Price = price };
			_order.AddProduct(product);
			return this;
		}
		public ShoppingCartBuilder RemoveProduct(string name)
		{
			var product = _order.Products.Find(p => p.Name == name);
			if (product != null)
			{
				_order.RemoveProduct(product);
			}
			return this;
		}
		public Order Checkout()
		{
			return _order;
		}
	}

	public static void Test()
	{
		var order = new ShoppingCartBuilder()
			.AddProduct("Laptop", 1000m)
			.AddProduct("Mouse", 50m)
			.RemoveProduct("Mouse")
			.AddProduct("Keyboard", 70m)
			.Checkout();
		Console.WriteLine($"Total Price: {order.TotalPrice}");
		// Outputs: Total Price: 1070
	}
}
