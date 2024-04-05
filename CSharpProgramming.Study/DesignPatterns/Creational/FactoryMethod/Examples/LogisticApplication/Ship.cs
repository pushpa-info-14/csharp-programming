namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication
{
    public class Ship : ITransport
    {
        public double GetDeliveryCost(int distance)
        {
            // Cost per mile for a ship might be $0.50
            return 0.50 * distance;
        }
    }
}
