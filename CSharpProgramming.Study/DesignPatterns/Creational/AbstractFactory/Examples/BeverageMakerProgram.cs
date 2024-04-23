namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples
{
    public class BeverageMakerProgram
    {
        // Abstract Products
        public interface IBeverage
        {
            void Drink();
        }

        public interface IIngredient
        {
            void Use();
        }

        // Concrete Products for Coffee
        public class Cappuccino : IBeverage
        {
            public void Drink()
            {
                Console.WriteLine("Drinking Cappuccino!");
            }
        }

        public class Milk : IIngredient
        {
            public void Use()
            {
                Console.WriteLine("Adding milk...");
            }
        }

        // Concrete Products for Tea
        public class GreenTea : IBeverage
        {
            public void Drink()
            {
                Console.WriteLine("Drinking Green Tea!");
            }
        }

        public class Sugar : IIngredient
        {
            public void Use()
            {
                Console.WriteLine("Adding sugar...");
            }
        }

        // Abstract Factory
        public interface IBeverageFactory
        {
            IBeverage PrepareBeverage();
            IIngredient AddIngredient();
        }

        // Concrete Factories
        public class CoffeeFactory : IBeverageFactory
        {
            public IBeverage PrepareBeverage() => new Cappuccino();
            public IIngredient AddIngredient() => new Milk();
        }

        public class TeaFactory : IBeverageFactory
        {
            public IBeverage PrepareBeverage() => new GreenTea();
            public IIngredient AddIngredient() => new Sugar();
        }

        // Client Code
        public class BeverageMaker
        {
            private readonly IBeverage _beverage;
            private readonly IIngredient _ingredient;

            public BeverageMaker(IBeverageFactory factory)
            {
                _beverage = factory.PrepareBeverage();
                _ingredient = factory.AddIngredient();
            }

            public void ServeBeverage()
            {
                _ingredient.Use();
                _beverage.Drink();
            }
        }

        public void Test()
        {
            Console.WriteLine("Ordering Coffee:");
            var coffeeFactory = new CoffeeFactory();
            var coffeeMaker = new BeverageMaker(coffeeFactory);
            coffeeMaker.ServeBeverage();

            Console.WriteLine("Ordering Tea:");
            var teaFactory = new TeaFactory();
            var teaMaker = new BeverageMaker(teaFactory);
            teaMaker.ServeBeverage();
        }
    }
}
