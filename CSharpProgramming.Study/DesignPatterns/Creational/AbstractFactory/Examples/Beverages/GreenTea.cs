namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class GreenTea : IBeverage
{
    public void Drink()
    {
        Console.WriteLine("Drinking Green Tea!");
    }
}