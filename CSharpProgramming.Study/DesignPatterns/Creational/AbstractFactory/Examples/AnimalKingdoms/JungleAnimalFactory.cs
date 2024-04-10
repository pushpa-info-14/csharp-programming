namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class JungleAnimalFactory : IAnimalFactory
{
    public IHerbivore CreateHerbivore() => new Deer();
    public ICarnivore CreateCarnivore() => new Tiger();
}