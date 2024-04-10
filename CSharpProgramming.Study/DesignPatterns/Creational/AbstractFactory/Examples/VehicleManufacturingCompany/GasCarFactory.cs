namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class GasCarFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new GasCarEngine();
    public ITire CreateTire() => new GasCarTire();
}