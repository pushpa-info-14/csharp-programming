using Newtonsoft.Json;

namespace CSharpProgramming.Tests.Utils
{
	public static class ConsoleLogger
	{
		public static void Print(object data)
		{
			Console.WriteLine(JsonConvert.SerializeObject(data));
		}
	}
}
