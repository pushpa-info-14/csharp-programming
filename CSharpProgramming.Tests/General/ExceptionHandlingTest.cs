using CSharpProgramming.Study.General;

namespace CSharpProgramming.Tests.General
{
    public class ExceptionHandlingTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            try
            {
                ExceptionHandling.Hello1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [Test]
        public void Test2()
        {
            try
            {
                ExceptionHandling.Hello2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [Test]
        public void Test3()
        {
            try
            {
                ExceptionHandling.Hello3();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
