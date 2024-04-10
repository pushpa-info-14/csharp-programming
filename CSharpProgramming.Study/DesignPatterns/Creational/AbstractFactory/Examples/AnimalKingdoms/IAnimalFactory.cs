namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public interface IAnimalFactory
{
    IHerbivore CreateHerbivore();
    ICarnivore CreateCarnivore();
}