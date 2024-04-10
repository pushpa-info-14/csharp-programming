namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class Milk : IIngredient
{
    public void Use()
    {
        Console.WriteLine("Adding milk...");
    }
}