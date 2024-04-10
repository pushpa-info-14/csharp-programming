namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
}