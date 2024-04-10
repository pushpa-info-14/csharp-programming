namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.AnimalKingdoms
{
    public class EcosystemProgram
    {
        public void Test()
        {
            Console.WriteLine("Jungle Ecosystem:");
            var jungleFactory = new JungleAnimalFactory();
            var jungle = new Ecosystem(jungleFactory);
            jungle.RunFoodChain();

            Console.WriteLine("Arctic Ecosystem:");
            var arcticFactory = new ArcticAnimalFactory();
            var arctic = new Ecosystem(arcticFactory);
            arctic.RunFoodChain();
        }
    }
}
