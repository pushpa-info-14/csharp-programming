namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public class VintageFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VintageChair();
    public ISofa CreateSofa() => new VintageSofa();
}