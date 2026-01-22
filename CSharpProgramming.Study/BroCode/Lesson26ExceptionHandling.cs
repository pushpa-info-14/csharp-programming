namespace CSharpProgramming.Study.BroCode
{
	public class Lesson26ExceptionHandling
	{
		public void Method1()
		{
			// exception - Errors that occur during execution

			// try     = Try some code that is considered "dangerous"
			// catch   = Catches and handles exceptions when they occur
			// finally = Always executes regardless if exception is caught or not

			try
			{
				Console.WriteLine("Enter number 1: ");
				var x = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter number 2: ");
				var y = Convert.ToInt32(Console.ReadLine());

				var result = x / y;

				Console.WriteLine("Result: " + result);
			}
			catch (FormatException)
			{
				Console.WriteLine("Enter only numbers");
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("You cannot divide by zero!");
			}
			catch
			{
				Console.WriteLine("Something went wrong!");
			}
			finally
			{
				Console.WriteLine("Thanks for visiting");
			}
		}
	}
}
