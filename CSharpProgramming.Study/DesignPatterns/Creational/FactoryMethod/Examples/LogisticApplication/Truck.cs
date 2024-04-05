namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication
{
    public class Truck : ITransport
    {
        public double GetDeliveryCost(int distance)
        {
            // Cost per mile for a truck might be $1.00
            return 1.00 * distance;
        }
    }
}
