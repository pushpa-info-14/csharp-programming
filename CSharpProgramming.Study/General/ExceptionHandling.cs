namespace CSharpProgramming.Study.General
{
	public static class ExceptionHandling
	{
		public static void Hello1()
		{
			try { }
			finally
			{
				var result = Convert.ToInt32("TEN");
			}
		}

		public static void Hello2()
		{
			try { }
			finally
			{
				Console.WriteLine("This line will be executed");
				var result = Convert.ToInt32("TEN");
				Console.WriteLine("This line will not be executed");
			}
		}

		public static void Hello3()
		{
			try
			{
				throw new Exception("Try block exception");
			}
			finally
			{
				throw new Exception("Finally block exception");
			}
		}
	}
}
