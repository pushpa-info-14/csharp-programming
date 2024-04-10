namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class Tiger : ICarnivore
{
    public void Hunt()
    {
        Console.WriteLine("Tiger is hunting.");
    }
}