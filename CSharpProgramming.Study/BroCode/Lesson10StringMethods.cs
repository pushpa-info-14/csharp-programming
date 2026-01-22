namespace CSharpProgramming.Study.BroCode
{
	public class Lesson10StringMethods
	{
		public void Method1()
		{
			var fulName = "Pushpa Kumara";
			var phoneNumber = "123-456-7890";

			Console.WriteLine(fulName.ToUpper());
			Console.WriteLine(fulName.ToLower());
			Console.WriteLine(phoneNumber.Replace("-", ""));
			Console.WriteLine(fulName.Insert(0, "Mr."));
			Console.WriteLine(fulName.Length);

			Console.WriteLine(fulName.Substring(0, 6));
			Console.WriteLine(fulName.Substring(7, 6));

			var firstName = fulName[..fulName.IndexOf(" ", StringComparison.Ordinal)];
			var lastName = fulName[(fulName.IndexOf(" ", StringComparison.Ordinal) + 1)..];
			Console.WriteLine(firstName);
			Console.WriteLine(lastName);
		}
	}
}
