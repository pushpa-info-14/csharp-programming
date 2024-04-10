namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.VehicleFactory
{
    // The ProductA1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularBike Product Belongs to the Bike product family
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}
