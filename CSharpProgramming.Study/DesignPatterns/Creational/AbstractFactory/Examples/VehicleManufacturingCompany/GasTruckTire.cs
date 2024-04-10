namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class GasTruckTire : ITire
{
    public string GetTireType()
    {
        return "Gas Truck Tire";
    }
}