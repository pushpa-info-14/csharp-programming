using System.Collections;

namespace CSharpProgramming.Study.General
{
	public class StoringDifferentTypesInAnArray
	{
		public void Method1()
		{
			object[] array = new object[3];
			array[0] = 1;
			array[1] = "string";

			Customer customer = new Customer();
			customer.Id = 1;
			customer.Name = "Pushpa";
			array[2] = customer;

			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
		public void Method2()
		{
			ArrayList array = new ArrayList();
			array.Add(1);
			array.Add("string");

			Customer customer = new Customer();
			customer.Id = 1;
			customer.Name = "Pushpa";
			array.Add(customer);

			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
	}

	internal class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
