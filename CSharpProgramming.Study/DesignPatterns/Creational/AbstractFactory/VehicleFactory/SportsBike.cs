namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.VehicleFactory
{
    // The ProductB1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following SportsBike Product Belongs to the Bike product family
    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}
