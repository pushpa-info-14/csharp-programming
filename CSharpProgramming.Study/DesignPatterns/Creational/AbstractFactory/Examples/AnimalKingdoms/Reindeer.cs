namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class Reindeer : IHerbivore
{
    public void Graze()
    {
        Console.WriteLine("Reindeer is grazing.");
    }
}