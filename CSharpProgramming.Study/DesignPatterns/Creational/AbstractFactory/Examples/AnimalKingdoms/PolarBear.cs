namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class PolarBear : ICarnivore
{
    public void Hunt()
    {
        Console.WriteLine("Polar bear is hunting.");
    }
}