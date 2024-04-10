namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Beverages
{
    public class BeverageMakerProgram
    {
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
