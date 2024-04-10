namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class CoffeeFactory : IBeverageFactory
{
    public IBeverage PrepareBeverage() => new Cappuccino();
    public IIngredient AddIngredient() => new Milk();
}