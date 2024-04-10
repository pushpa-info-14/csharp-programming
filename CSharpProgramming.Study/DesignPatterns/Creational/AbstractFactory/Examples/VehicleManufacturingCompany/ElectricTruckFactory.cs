namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricTruckFactory : IVehicleFactory
{
    public IEngine CreateEngine() => new ElectricTruckEngine();
    public ITire CreateTire() => new ElectricTruckTire();
}