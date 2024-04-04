namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.TransportApplication
{
    public class Bus : ITransport
    {
        public void StartRoute()
        {
            Console.WriteLine("Starting the journey with a bus!");
            // Logic related to starting a bus route
        }
    }
}
