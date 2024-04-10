namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}