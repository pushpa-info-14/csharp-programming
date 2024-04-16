namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentPizzaBuilder;

public class Pizza
{
    public string? Size { get; set; }
    public string? Crust { get; set; }
    public List<string> Toppings { get; } = new();

    public override string ToString()
    {
        return $"{Size} inch {Crust} crust pizza with {string.Join(", ", Toppings)}";
    }
}