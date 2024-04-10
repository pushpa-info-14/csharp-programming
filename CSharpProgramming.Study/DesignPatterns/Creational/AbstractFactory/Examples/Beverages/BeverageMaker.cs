namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class BeverageMaker
{
    private readonly IBeverage _beverage;
    private readonly IIngredient _ingredient;

    public BeverageMaker(IBeverageFactory factory)
    {
        _beverage = factory.PrepareBeverage();
        _ingredient = factory.AddIngredient();
    }

    public void ServeBeverage()
    {
        _ingredient.Use();
        _beverage.Drink();
    }
}