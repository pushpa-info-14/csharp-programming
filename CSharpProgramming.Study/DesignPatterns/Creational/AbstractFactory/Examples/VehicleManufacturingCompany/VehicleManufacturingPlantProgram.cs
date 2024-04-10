namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany
{
    public class VehicleManufacturingPlantProgram
    {
        public void Test()
        {
            var gasCarFactory = new GasCarFactory();
            var gasCarPlant = new VehicleManufacturingPlant(gasCarFactory);
            gasCarPlant.DescribeVehicle();

            var electricCarFactory = new ElectricCarFactory();
            var electricCarPlant = new VehicleManufacturingPlant(electricCarFactory);
            electricCarPlant.DescribeVehicle();

            var gasTruckFactory = new GasTruckFactory();
            var gasTruckPlant = new VehicleManufacturingPlant(gasTruckFactory);
            gasTruckPlant.DescribeVehicle();

            var electricTruckFactory = new ElectricTruckFactory();
            var electricTruckPlant = new VehicleManufacturingPlant(electricTruckFactory);
            electricTruckPlant.DescribeVehicle();
        }
    }
}
