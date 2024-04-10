namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms;

public class Ecosystem
{
    private readonly IHerbivore _herbivore;
    private readonly ICarnivore _carnivore;

    public Ecosystem(IAnimalFactory factory)
    {
        _herbivore = factory.CreateHerbivore();
        _carnivore = factory.CreateCarnivore();
    }

    public void RunFoodChain()
    {
        _herbivore.Graze();
        _carnivore.Hunt();
    }
}