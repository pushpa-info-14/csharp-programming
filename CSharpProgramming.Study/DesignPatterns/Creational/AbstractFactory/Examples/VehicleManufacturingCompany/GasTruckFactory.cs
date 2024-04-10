namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class GasTruckFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new GasTruckEngine();
    public ITire CreateTire() => new GasTruckTire();
}