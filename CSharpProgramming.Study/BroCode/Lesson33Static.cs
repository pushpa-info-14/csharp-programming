namespace CSharpProgramming.Study.BroCode
{
    public class Lesson33Static
    {
        public void Method1()
        {
            // static - Modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            var car1 = new Car("Mustang");
            Console.WriteLine(Car.NumberOfCars);

            var car2 = new Car("Corvette");
            Console.WriteLine(Car.NumberOfCars);
        }

        class Car
        {
            public static int NumberOfCars = 0;
            public string Name;

            public Car(string name)
            {
                Name = name;
                NumberOfCars++;
            }
        }
    }
}
