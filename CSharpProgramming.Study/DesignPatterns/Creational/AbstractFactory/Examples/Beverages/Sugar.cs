namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages;

public class Sugar : IIngredient
{
    public void Use()
    {
        Console.WriteLine("Adding sugar...");
    }
}