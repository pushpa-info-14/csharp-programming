namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class Cappuccino : IBeverage
{
    public void Drink()
    {
        Console.WriteLine("Drinking Cappuccino!");
    }
}