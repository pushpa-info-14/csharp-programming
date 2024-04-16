namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentPizzaBuilder
{
    public class PizzaBuilderProgram
    {
        public void Test()
        {
            var builder = new PizzaBuilder();
            var myPizza = builder.WithSize("12")
                .WithCrust("thin")
                .AddTopping("Mushrooms")
                .AddTopping("Pepperoni")
                .Build();

            Console.WriteLine(myPizza.ToString());
        }
    }
}
