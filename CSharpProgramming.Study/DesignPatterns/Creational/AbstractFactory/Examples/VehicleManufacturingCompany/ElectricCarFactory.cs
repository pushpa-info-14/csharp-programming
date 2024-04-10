namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricCarFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new ElectricCarEngine();
    public ITire CreateTire() => new ElectricCarTire();
}