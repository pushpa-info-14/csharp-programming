namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    // The ProductA2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following Online Product Belongs to the Source product family
    public class Online : ISource
    {
        public string GetSourceName()
        {
            return "Dot Net Tutorials Zoom Classes";
        }
    }
}
