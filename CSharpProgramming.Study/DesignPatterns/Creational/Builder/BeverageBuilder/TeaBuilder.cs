namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.BeverageBuilder;

public class TeaBuilder : BeverageBuilder
{
    public override void SetWater()
    {
        Console.WriteLine("Step 1 : Boiling water");
        GetBeverage().Water = 50;
    }

    public override void SetMilk()
    {
        Console.WriteLine("Step 2 : Adding milk");
        GetBeverage().Milk = 60;
    }

    public override void SetSugar()
    {
        Console.WriteLine("Step 3 : Adding Sugar");
        GetBeverage().Sugar = 15;
    }

    public override void SetPowderQuantity()
    {
        Console.WriteLine("Step 4 : Adding 20 Grams of coffee powder");
        GetBeverage().PowderQuantity = 20;
    }

    public override void SetBeverageType()
    {
        Console.WriteLine("Tea");
        GetBeverage().BeverageName = "Tea";
    }
}