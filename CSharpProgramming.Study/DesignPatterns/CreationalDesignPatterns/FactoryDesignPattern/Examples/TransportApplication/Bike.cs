namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.TransportApplication
{
    public class Bike : ITransport
    {
        public void StartRoute()
        {
            Console.WriteLine("Starting the journey with a bike!");
            // Logic related to starting a bike route
        }
    }
}
