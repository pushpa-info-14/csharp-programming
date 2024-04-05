namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleFactory
{
    public class VehicleFactoryProgram
    {
        public void Test()
        {
            // Fetch the Regular Bike and Car Details
            // Creating RegularVehicleFactory instance
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

            //regularVehicleFactory.CreateBike() will create and return Regular Bike
            var regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();

            //regularVehicleFactory.CreateCar() will create and return Regular Car
            var regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();

            // Fetch the Sports Bike and Car Details Created
            // Creating SportsVehicleFactory instance 
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

            //sportsVehicleFactory.CreateBike() will create and return Sports Bike
            var sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();

            //sportsVehicleFactory.CreateCar() will create and return Sports Car
            var sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}
