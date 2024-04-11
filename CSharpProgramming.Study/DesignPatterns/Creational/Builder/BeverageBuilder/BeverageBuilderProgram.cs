namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.BeverageBuilder
{
    public class BeverageBuilderProgram
    {
        public void Test()
        {
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuilder tea = new TeaBuilder();
            var beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
        }
    }
}
