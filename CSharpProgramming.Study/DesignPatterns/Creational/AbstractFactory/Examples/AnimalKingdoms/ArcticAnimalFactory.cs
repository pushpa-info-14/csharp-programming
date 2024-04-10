namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class ArcticAnimalFactory : IAnimalFactory
{
    public IHerbivore CreateHerbivore() => new Reindeer();
    public ICarnivore CreateCarnivore() => new PolarBear();
}