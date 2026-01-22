namespace CSharpProgramming.Study.BroCode
{
	public class Lesson12Switches
	{
		public void Method1()
		{
			// switch - An efficient alternative to many else if statements

			var day = "Monday";

			switch (day)
			{
				case "Monday":
					Console.WriteLine("It is Monday!");
					break;
				case "Tuesday":
					Console.WriteLine("It is Tuesday!");
					break;
				case "Wednesday":
					Console.WriteLine("It is Wednesday!");
					break;
				case "Thursday":
					Console.WriteLine("It is Thursday!");
					break;
				case "Friday":
					Console.WriteLine("It is Friday!");
					break;
				case "Saturday":
					Console.WriteLine("It is Saturday!");
					break;
				case "Sunday":
					Console.WriteLine("It is Sunday!");
					break;
				default:
					Console.WriteLine(day + " is not a day!");
					break;
			}
		}
	}
}
