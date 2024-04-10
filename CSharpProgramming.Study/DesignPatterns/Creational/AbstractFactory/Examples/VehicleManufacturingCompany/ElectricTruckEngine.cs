namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricTruckEngine : IEngine
{
    public string GetEngineType()
    {
        return "Electric Truck Engine";
    }
}