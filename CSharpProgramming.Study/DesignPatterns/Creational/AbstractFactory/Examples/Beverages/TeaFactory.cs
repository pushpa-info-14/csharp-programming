namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class TeaFactory : IBeverageFactory
{
    public IBeverage PrepareBeverage() => new GreenTea();
    public IIngredient AddIngredient() => new Sugar();
}