namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class GasCarEngine : IEngine
{
    public string GetEngineType()
    {
        return "Gas Car Engine";
    }
}