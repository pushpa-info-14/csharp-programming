namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication
{
    public class ShipFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
