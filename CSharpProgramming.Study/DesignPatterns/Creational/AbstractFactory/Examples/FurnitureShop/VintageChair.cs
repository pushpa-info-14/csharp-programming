namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public class VintageChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a vintage chair.");
    }
}