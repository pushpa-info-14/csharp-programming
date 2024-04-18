namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class CarConfiguratorApplication
    {
        // Prototype - ICarPrototype Interface
        public interface ICarPrototype
        {
            ICarPrototype Clone();
        }

        // Concrete Prototype - Car Class
        public class Car : ICarPrototype
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public string Engine { get; set; }
            public bool Sunroof { get; set; }

            public ICarPrototype Clone()
            {
                // Using MemberwiseClone for simplicity, which is a shallow copy.
                // For complex objects, you might need to implement a deep copy.
                return (ICarPrototype)this.MemberwiseClone();
            }

            public override string ToString()
            {
                return $"{Model} | Color: {Color} | Engine: {Engine} | Sunroof: {Sunroof}";
            }
        }

        // Client Code
        public void Test()
        {
            // Create an initial car configuration
            var prototypeCar = new Car
            {
                Model = "Sedan",
                Color = "Blue",
                Engine = "V6",
                Sunroof = true
            };

            Console.WriteLine("Original Car Configuration:");
            Console.WriteLine(prototypeCar);

            // Now clone the prototype and make modifications for a new configuration
            var clonedCar = (Car)prototypeCar.Clone();
            clonedCar.Color = "Red";
            clonedCar.Sunroof = false;

            Console.WriteLine("\nCloned and Modified Car Configuration:");
            Console.WriteLine(clonedCar);
        }
    }
}
