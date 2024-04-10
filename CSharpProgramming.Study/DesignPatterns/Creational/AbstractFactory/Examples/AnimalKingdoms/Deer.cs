namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class Deer : IHerbivore
{
    public void Graze()
    {
        Console.WriteLine("Deer is grazing.");
    }
}