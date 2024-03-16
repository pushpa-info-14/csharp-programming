namespace CSharpProgramming.Study.BroCode
{
    public class Lesson39MethodOverriding
    {
        public void Method1()
        {
            // method overriding - Provides a new version of a method inherited from a parent class.
            //                     Inherited method must be: abstract, virtual or already overriden.
            //                     Used with ToString(), polymorphism.

            var dog = new Dog();
            var cat = new Cat();

            dog.Speak();
            cat.Speak();
        }

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal goes *brrr*");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The dog goes *woof*");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The cat goes *meow*");
            }
        }
    }
}
