namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.TransportApplication
{
    public class TransportProgram
    {
        public void Test()
        {
            var chosenTransport = TransportFactory.CreateTransport("car");
            chosenTransport.StartRoute();

            chosenTransport = TransportFactory.CreateTransport("bus");
            chosenTransport.StartRoute();

            chosenTransport = TransportFactory.CreateTransport("bike");
            chosenTransport.StartRoute();
        }
    }
}
