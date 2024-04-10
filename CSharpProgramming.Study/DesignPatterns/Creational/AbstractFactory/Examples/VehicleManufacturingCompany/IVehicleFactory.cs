namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public interface IVehicleFactory
{
    IEngine CreateEngine();
    ITire CreateTire();
}