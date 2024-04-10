namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class ElectricCarTire : ITire
{
    public string GetTireType()
    {
        return "Electric Car Tire";
    }
}