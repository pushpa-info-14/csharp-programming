namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    // The ProductB2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following Offline Product Belongs to the Source product family
    public class Offline : ISource
    {
        public string GetSourceName()
        {
            return "Dot Net Tutorials Class Room Training";
        }
    }
}
