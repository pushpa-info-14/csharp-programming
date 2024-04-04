

using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- CreditCard");
            new CreditCardProgram().Test();

            Console.WriteLine("\n---- NotificationSystem");
            new NotificationSystemProgram().Test();
        }
    }
}
