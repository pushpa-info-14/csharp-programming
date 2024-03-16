namespace CSharpProgramming.Study.BroCode
{
    public class Lesson42Interfaces
    {
        public void Method1()
        {
            // interface - Defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             Benefit = security + multiple inheritance + "plug-and-play"

            var rabbit = new Rabbit();
            var hawk = new Hawk();
            var fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("Fish swims away!");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}
