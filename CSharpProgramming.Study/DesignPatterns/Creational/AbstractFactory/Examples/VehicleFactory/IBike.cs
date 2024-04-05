namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleFactory
{
    // The AbstractProductA interface
    // Each distinct product of the Bike product family should have a base interface.
    // All variants of Bike products must implement this IBike interface.
    public interface IBike
    {
        void GetDetails();
    }
}
