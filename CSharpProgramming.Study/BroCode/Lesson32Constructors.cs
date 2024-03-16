namespace CSharpProgramming.Study.BroCode
{
    public class Lesson32Constructors
    {
        public void Method1()
        {
            // constructor - A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            var human1 = new Human("Pushpa", 30);
            var human2 = new Human("Kumara", 37);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();
        }

        class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Human(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Eat()
            {
                Console.WriteLine(Name + " is eating");
            }

            public void Sleep()
            {
                Console.WriteLine(Name + " is sleeping");
            }
        }
    }
}
