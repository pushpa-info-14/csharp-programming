namespace CSharpProgramming.Study.DesignPatterns.Structural.Decorator
{
    public class CarProgram
    {
        // This is the Base Component that defines operations that can be altered by decorators.
        public interface ICar
        {
            ICar ManufactureCar();
        }

        // Concrete Components provide default implementations of the operations.
        // There might be several variations of these classes.
        public class BMWCar : ICar
        {
            private readonly string CarName = "BMW";
            public string CarBody { get; set; }
            public string CarDoor { get; set; }
            public string CarWheels { get; set; }
            public string CarGlass { get; set; }
            public string Engine { get; set; }
            public override string ToString()
            {
                return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                                + CarWheels + ", CarGlass=" + CarGlass + ", Engine=" + Engine + "]";
            }
            public ICar ManufactureCar()
            {
                CarBody = "carbon fiber material";
                CarDoor = "4 car doors";
                CarWheels = "6 car glasses";
                CarGlass = "4 MRF wheels";
                return this;
            }
        }

        // The Base Decorator class is also inherited from the same interface as the other Concrete Components inherited. 
        // The primary responsibility of this Base Decorator class is to define the wrapping interface for all concrete decorators. 
        // The default implementation of the wrapping code includes a field for storing a wrapped component and
        // we need to initialize that field. Here, we are initializing that field using the class constructor

        // Inherited from the Base Component Interface
        public abstract class CarDecorator : ICar
        {
            // Create a Field to store the Concrete Component
            protected ICar car;

            // Initializing the Field using Constructor
            // While Creating an instance of the CarDecorator (Instance of the Child Class that Implements CarDecorator abstract)
            // We need to pass the existing car object which we want to decorate
            public CarDecorator(ICar car)
            {
                // Store that existing car object in the car variable
                this.car = car;
            }

            // Providing Implementation for the Base Component Interface
            // Here, we are just calling the Concrete Component ManufactureCar method
            // We are making this Method Virtual to allow the Child Concrete Decorator class to override
            public virtual ICar ManufactureCar()
            {
                // Call the Existing Car Object ManufactureCar method to return the car without engine
                // Later in the Child class of this abstract we will see how to call this method 
                // and how to add an Engine
                return car.ManufactureCar();
            }
        }

        // The following Concrete Decorator class will add Petrol Engine to the Existing Car
        class PetrolCarDecorator : CarDecorator
        {
            // Pass the existing car object while creating the Instance of PetrolCarDecorator class
            // Also pass the same existing pizza object to the base class constructor 
            // i.e. CarDecorator abstract class constructor
            public PetrolCarDecorator(ICar car) : base(car)
            {
            }
            // Overriding the ManufactureCar method to add Petrol Engine
            public override ICar ManufactureCar()
            {
                // First Call the Concrete Components ManufactureCar Method 
                car.ManufactureCar();
                // Then Add a Petrol Engine by calling the AddEngine Method
                AddEngine(car);
                return car;
            }
            public void AddEngine(ICar car)
            {
                if (car is BMWCar BMWCar)
                {
                    BMWCar.Engine = "Petrol Engine";
                    Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
                }
            }
        }

        class DieselCarDecorator : CarDecorator
        {
            public DieselCarDecorator(ICar car) : base(car)
            {
            }
            public override ICar ManufactureCar()
            {
                car.ManufactureCar();
                AddEngine(car);
                return car;
            }
            public void AddEngine(ICar car)
            {
                if (car is BMWCar BMWCar)
                {
                    BMWCar.Engine = "Diesel Engine";
                    Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
                }
            }
        }

        public void Test()
        {
            // Create an instance of Concrete Component BMWCar
            ICar bmwCar1 = new BMWCar();

            // Calling the ManufactureCar method will create the BMWCar without an engine
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            // Adding Diesel Engine to the bmwCar1
            // Create an instance DieselCarDecorator class and 
            // pass existing bmwCar1 as an argument to the Constructor which we want to decorate
            DieselCarDecorator carWithDieselEngine = new(bmwCar1);

            // Calling the ManufactureCar method on the carWithDieselEngine object will add Diesel Engine to the bmwCar1 car
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            // The Process is the same for adding Petrol Engine to the existing Car
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
        }
    }
}
