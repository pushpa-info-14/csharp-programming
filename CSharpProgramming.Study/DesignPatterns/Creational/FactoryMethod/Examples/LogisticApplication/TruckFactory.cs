namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication
{
    public class TruckFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
