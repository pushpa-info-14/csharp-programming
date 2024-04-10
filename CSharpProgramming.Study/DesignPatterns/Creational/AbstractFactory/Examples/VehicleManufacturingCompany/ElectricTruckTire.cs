namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricTruckTire : ITire
{
    public string GetTireType()
    {
        return "Electric Truck Tire";
    }
}