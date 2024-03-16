namespace CSharpProgramming.Study.BroCode
{
    public class Lesson38ObjectsAsArguments
    {
        public void Method1()
        {
            var car1 = new Car("Mustang", "red");

            Console.WriteLine(car1.Color);

            ChangeColor(car1, "silver");
            Console.WriteLine(car1.Color);

            var car2 = Copy(car1);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Color);
        }

        private void ChangeColor(Car car, string color)
        {
            car.Color = color;
        }

        private Car Copy(Car car)
        {
            return new Car(car.Model, car.Color);
        }

        class Car
        {
            public string Model;
            public string Color;

            public Car(string model, string color)
            {
                Model = model;
                Color = color;
            }
        }
    }
}
