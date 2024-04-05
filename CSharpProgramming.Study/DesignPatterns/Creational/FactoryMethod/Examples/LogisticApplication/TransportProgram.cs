namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication
{
    public class TransportProgram
    {
        public void Test()
        {
            TransportFactory factory = new TruckFactory();
            var transport = factory.CreateTransport();
            Console.WriteLine($"Truck delivery cost: ${transport.GetDeliveryCost(100)} for 100 miles.");

            factory = new ShipFactory();
            transport = factory.CreateTransport();
            Console.WriteLine($"Ship delivery cost: ${transport.GetDeliveryCost(100)} for 100 miles.");
        }
    }
}
