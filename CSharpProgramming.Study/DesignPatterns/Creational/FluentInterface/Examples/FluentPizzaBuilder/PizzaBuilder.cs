namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentPizzaBuilder;

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