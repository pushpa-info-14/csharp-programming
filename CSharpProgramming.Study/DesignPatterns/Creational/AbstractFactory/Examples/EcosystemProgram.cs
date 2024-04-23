namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples
{
    public class EcosystemProgram
    {
        // Abstract Products
        public interface IHerbivore
        {
            void Graze();
        }

        public interface ICarnivore
        {
            void Hunt();
        }

        // Concrete Products for Jungle
        public class Deer : IHerbivore
        {
            public void Graze()
            {
                Console.WriteLine("Deer is grazing.");
            }
        }

        public class Tiger : ICarnivore
        {
            public void Hunt()
            {
                Console.WriteLine("Tiger is hunting.");
            }
        }

        // Concrete Products for Arctic
        public class Reindeer : IHerbivore
        {
            public void Graze()
            {
                Console.WriteLine("Reindeer is grazing.");
            }
        }

        public class PolarBear : ICarnivore
        {
            public void Hunt()
            {
                Console.WriteLine("Polar bear is hunting.");
            }
        }

        // Abstract Factory
        public interface IAnimalFactory
        {
            IHerbivore CreateHerbivore();
            ICarnivore CreateCarnivore();
        }

        // Concrete Factories
        public class JungleAnimalFactory : IAnimalFactory
        {
            public IHerbivore CreateHerbivore() => new Deer();
            public ICarnivore CreateCarnivore() => new Tiger();
        }

        public class ArcticAnimalFactory : IAnimalFactory
        {
            public IHerbivore CreateHerbivore() => new Reindeer();
            public ICarnivore CreateCarnivore() => new PolarBear();
        }

        // Client Code
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
