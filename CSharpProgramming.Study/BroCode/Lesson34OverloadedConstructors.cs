namespace CSharpProgramming.Study.BroCode
{
	public class Lesson34OverloadedConstructors
	{
		public void Method1()
		{
			// overloaded constructors -  Technique to create multiple constructors,
			//                            with a different set of parameters.
			//                            name + parameters = signature

			var pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella");
			var pizza2 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
		}

		class Pizza
		{
			public string Bread;
			public string Sauce;
			public string Cheese;
			public string Topping = string.Empty;

			public Pizza(string bread, string sauce, string cheese)
			{
				Bread = bread;
				Sauce = sauce;
				Cheese = cheese;
			}

			public Pizza(string bread, string sauce, string cheese, string topping)
			{
				Bread = bread;
				Sauce = sauce;
				Cheese = cheese;
				Topping = topping;
			}
		}
	}
}
