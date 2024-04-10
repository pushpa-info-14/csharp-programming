namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
}