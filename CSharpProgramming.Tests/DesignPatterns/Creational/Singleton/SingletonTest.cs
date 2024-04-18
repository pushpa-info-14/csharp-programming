using CSharpProgramming.Study.DesignPatterns.Creational.Singleton;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Singleton
{
    public class SingletonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- NoThreadSafeSingleton");
            new NoThreadSafeSingleton().Test();

            Console.WriteLine("\n---- WhyIsSingletonClassIsSealed");
            new WhyIsSingletonClassIsSealed().Test();

            Console.WriteLine("\n---- NoThreadSafeSingletonInMultiThreadedEnvironment");
            new NoThreadSafeSingletonInMultiThreadedEnvironment().Test();

            Console.WriteLine("\n---- ThreadSafeSingletonUsingLocks");
            new ThreadSafeSingletonUsingLocks().Test();

            Console.WriteLine("\n---- ThreadSafeSingletonDoubleCheckedLockingApproach");
            new ThreadSafeSingletonDoubleCheckedLockingApproach().Test();

            Console.WriteLine("\n---- ThreadSafeSingletonUsingLazyLoading");
            new ThreadSafeSingletonUsingLazyLoading().Test();

            Console.WriteLine("\n---- ThreadSafeSingletonUsingEagerLoading");
            new ThreadSafeSingletonUsingEagerLoading().Test();
        }
    }
}
