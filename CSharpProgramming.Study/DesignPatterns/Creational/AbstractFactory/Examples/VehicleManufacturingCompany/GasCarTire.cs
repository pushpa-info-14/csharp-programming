namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;

public class GasCarTire : ITire
{
    public string GetTireType()
    {
        return "Gas Car Tire";
    }
}