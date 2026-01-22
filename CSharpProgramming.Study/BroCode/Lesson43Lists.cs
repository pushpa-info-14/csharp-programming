namespace CSharpProgramming.Study.BroCode
{
	public class Lesson43Lists
	{
		public void Method1()
		{
			// List - Data structure that represents a list of objects that can be accessed by index.
			//        Similar to array, but can dynamically increase/decrease in size.
			//        using System.Collections.Generic;

			var foods = new List<string>();

			foods.Add("fries");
			foods.Add("pizza");
			foods.Add("hamburger");
			foods.Add("hotdog");
			foods.Add("fries");

			//foods.Remove("fries");
			foods.Insert(0, "sushi");
			Console.WriteLine(foods.Count);
			Console.WriteLine(foods.IndexOf("pizza"));
			Console.WriteLine(foods.LastIndexOf("fries"));
			Console.WriteLine(foods.Contains("pizza"));
			foreach (var food in foods)
			{
				Console.WriteLine(food);
			}

			foods.Sort();
			foreach (var food in foods)
			{
				Console.WriteLine(food);
			}

			foods.Reverse();
			foreach (var food in foods)
			{
				Console.WriteLine(food);
			}

			foods.Clear();
		}
	}
}
