namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples
{
    public class PizzaBuilderProgram
    {
        public class Pizza
        {
            public string Size { get; set; }
            public string Crust { get; set; }
            public List<string> Toppings { get; } = new();

            public override string ToString()
            {
                return $"{Size} inch {Crust} crust pizza with {string.Join(", ", Toppings)}";
            }
        }

        public class PizzaBuilder
        {
            private readonly Pizza _pizza = new();

            public PizzaBuilder WithSize(string size)
            {
                _pizza.Size = size;
                return this;
            }

            public PizzaBuilder WithCrust(string crust)
            {
                _pizza.Crust = crust;
                return this;
            }

            public PizzaBuilder AddTopping(string topping)
            {
                _pizza.Toppings.Add(topping);
                return this;
            }

            public Pizza Build()
            {
                return _pizza;
            }
        }

        public void Test()
        {
            var builder = new PizzaBuilder();
            var myPizza = builder.WithSize("12")
                .WithCrust("thin")
                .AddTopping("Mushrooms")
                .AddTopping("Pepperoni")
                .Build();

            Console.WriteLine(myPizza.ToString());
        }
    }
}
