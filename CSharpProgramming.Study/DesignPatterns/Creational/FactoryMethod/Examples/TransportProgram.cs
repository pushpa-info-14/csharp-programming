namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples
{
    public class TransportProgram
    {
        // Product(Interface)
        public interface ITransport
        {
            double GetDeliveryCost(int distance);
        }

        // Concrete Products
        public class Truck : ITransport
        {
            public double GetDeliveryCost(int distance)
            {
                // Cost per mile for a truck might be $1.00
                return 1.00 * distance;
            }
        }

        public class Ship : ITransport
        {
            public double GetDeliveryCost(int distance)
            {
                // Cost per mile for a ship might be $0.50
                return 0.50 * distance;
            }
        }

        // Creator(Abstract Class)
        public abstract class TransportFactory
        {
            public abstract ITransport CreateTransport();
        }

        // Concrete Creators
        public class TruckFactory : TransportFactory
        {
            public override ITransport CreateTransport()
            {
                return new Truck();
            }
        }

        public class ShipFactory : TransportFactory
        {
            public override ITransport CreateTransport()
            {
                return new Ship();
            }
        }

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
