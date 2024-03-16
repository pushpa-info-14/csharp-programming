namespace CSharpProgramming.Study.BroCode
{
    public class Lesson41Polymorphism
    {
        public void Method1()
        {
            // polymorphism - Greek word that means to "have many forms".
            //                Objects can be identified by more than one type.
            //                Ex. A Doge is also: Canine, Animal, Organism.

            var car = new Car();
            var bicycle = new Bicycle();
            var boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (var vehicle in vehicles)
            {
                vehicle.Go();
            }
        }

        class Vehicle
        {
            public virtual void Go() { }
        }

        class Car : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The car is moving!");
            }
        }

        class Bicycle : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The bicycle is moving!");
            }
        }

        class Boat : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The boat is moving!");
            }
        }
    }
}
