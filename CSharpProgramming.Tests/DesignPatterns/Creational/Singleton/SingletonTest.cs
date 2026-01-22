using CSharpProgramming.Study.DesignPatterns.Creational.Singleton;
using CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Singleton;

public class SingletonTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- NoThreadSafeSingleton");
		NoThreadSafeSingleton.Test();

		Console.WriteLine("\n---- WhyIsSingletonClassIsSealed");
		WhyIsSingletonClassIsSealed.Test();

		Console.WriteLine("\n---- NoThreadSafeSingletonInMultiThreadedEnvironment");
		NoThreadSafeSingletonInMultiThreadedEnvironment.Test();

		Console.WriteLine("\n---- ThreadSafeSingletonUsingLocks");
		ThreadSafeSingletonUsingLocks.Test();

		Console.WriteLine("\n---- ThreadSafeSingletonDoubleCheckedLockingApproach");
		ThreadSafeSingletonDoubleCheckedLockingApproach.Test();

		Console.WriteLine("\n---- ThreadSafeSingletonUsingLazyLoading");
		ThreadSafeSingletonUsingLazyLoading.Test();

		Console.WriteLine("\n---- ThreadSafeSingletonUsingEagerLoading");
		ThreadSafeSingletonUsingEagerLoading.Test();
	}

	[Fact]
	public void Test2()
	{
		Console.WriteLine("\n---- Caching");
		Caching.Test();

		Console.WriteLine("\n---- ServiceProxies");
		ServiceProxies.Test();

		//Console.WriteLine("\n---- DatabaseConnectionManagement");
		//DatabaseConnectionManagement.Test();

		Console.WriteLine("\n---- LoadBalancers");
		LoadBalancers.Test();

		Console.WriteLine("\n---- ApplicationConfigurationManagement");
		ApplicationConfigurationManagement.Test();

		Console.WriteLine("\n---- UserSessionManagement");
		UserSessionManagement.Test();

		Console.WriteLine("\n---- ApplicationThemeManager");
		ApplicationThemeManager.Test();

		Console.WriteLine("\n---- SystemInformationGathererProgram");
		SystemInformationGathererProgram.Test();

		Console.WriteLine("\n---- NotificationManagerProgram");
		NotificationManagerProgram.Test();

		Console.WriteLine("\n---- TaskSchedulerProgram");
		TaskSchedulerProgram.Test();

		Console.WriteLine("\n---- ServiceLocatorProgram");
		ServiceLocatorProgram.Test();

		Console.WriteLine("\n---- DataSharing");
		DataSharing.Test();

		Console.WriteLine("\n---- ApplicationCounterManager");
		ApplicationCounterManager.Test();
	}
}
