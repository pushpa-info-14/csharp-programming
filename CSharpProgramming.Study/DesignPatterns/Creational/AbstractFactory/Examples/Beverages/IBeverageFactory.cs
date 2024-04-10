namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public interface IBeverageFactory
{
    IBeverage PrepareBeverage();
    IIngredient AddIngredient();
}