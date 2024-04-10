namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class VehicleManufacturingPlant
{
    private readonly IEngine _engine;
    private readonly ITire _tire;
    public VehicleManufacturingPlant(IVehicleFactory factory)
    {
        _engine = factory.CreateEngine();
        _tire = factory.CreateTire();
    }
    public void DescribeVehicle()
    {
        Console.WriteLine($"Vehicle with Engine: {_engine.GetEngineType()} and Tire: {_tire.GetTireType()}");
    }
}