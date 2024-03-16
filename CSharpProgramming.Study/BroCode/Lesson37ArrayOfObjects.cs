namespace CSharpProgramming.Study.BroCode
{
    public class Lesson37ArrayOfObjects
    {
        public void Method1()
        {
            //var garage = new Car[3];

            //var car1 = new Car("Mustang");
            //var car2 = new Car("Corvette");
            //var car3 = new Car("Lambo");

            //garage[0] = car1;
            //garage[1] = car2;
            //garage[2] = car3;

            //Console.WriteLine(garage[0].Model);
            //Console.WriteLine(garage[1].Model);
            //Console.WriteLine(garage[2].Model);

            var garage = new Car[] { new("Mustang"), new("Corvette"), new("Lambo") };

            foreach (var car in garage)
            {
                Console.WriteLine(car.Model);
            }
        }

        class Car
        {
            public string Model;

            public Car(string model)
            {
                Model = model;
            }
        }
    }
}
