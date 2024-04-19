using CSharpProgramming.Study.DesignPatterns.Creational.Singleton;
using CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;

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

        [Test]
        public void Test2()
        {
            Console.WriteLine("\n---- Caching");
            new Caching().Test();

            Console.WriteLine("\n---- ServiceProxies");
            new ServiceProxies().Test();

            //Console.WriteLine("\n---- DatabaseConnectionManagement");
            //new DatabaseConnectionManagement().Test();

            Console.WriteLine("\n---- LoadBalancers");
            new LoadBalancers().Test();

            Console.WriteLine("\n---- ApplicationConfigurationManagement");
            new ApplicationConfigurationManagement().Test();

            Console.WriteLine("\n---- UserSessionManagement");
            new UserSessionManagement().Test();

            Console.WriteLine("\n---- ApplicationThemeManager");
            new ApplicationThemeManager().Test();

            Console.WriteLine("\n---- SystemInformationGathererProgram");
            new SystemInformationGathererProgram().Test();

            Console.WriteLine("\n---- NotificationManagerProgram");
            new NotificationManagerProgram().Test();

            Console.WriteLine("\n---- TaskSchedulerProgram");
            new TaskSchedulerProgram().Test();

            Console.WriteLine("\n---- ServiceLocatorProgram");
            new ServiceLocatorProgram().Test();

            Console.WriteLine("\n---- DataSharing");
            new DataSharing().Test();

            Console.WriteLine("\n---- ApplicationCounterManager");
            new ApplicationCounterManager().Test();
        }
    }
}
