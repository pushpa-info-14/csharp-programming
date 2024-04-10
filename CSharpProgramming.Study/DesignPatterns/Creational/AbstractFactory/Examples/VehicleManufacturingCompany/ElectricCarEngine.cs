namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricCarEngine : IEngine
{
    public string GetEngineType()
    {
        return "Electric Car Engine";
    }
}