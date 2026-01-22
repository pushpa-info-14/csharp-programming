namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype;

public class ShallowAndDeepCopyProgram
{
	private class Employee
	{
		public string Name { get; set; }

		public string Department { get; set; }

		public Address EmpAddress { get; set; }

		// Creating a Clone Object of the Current Object using Shallow Copy
		public Employee GetShallowCopy()
		{
			var employee = (Employee)MemberwiseClone();
			return employee;
		}

		// Creating a Clone Object of the Current Object using Deep Copy
		public Employee GetDeepCopy()
		{
			var employee = (Employee)MemberwiseClone();
			employee.EmpAddress = EmpAddress.GetClone();
			return employee;
		}
	}

	private class Address
	{
		public string AddressLine1 { get; set; }

		public Address GetClone()
		{
			return (Address)MemberwiseClone();
		}
	}

	public static void Test()
	{
		// Example to Understand Deep Copy and Shallow Copy in C#
		// Creating Employee Object
		var emp1 = new Employee
		{
			Name = "Anurag",
			Department = "IT",
			EmpAddress = new Address() { AddressLine1 = "BBSR" }
		};

		// Creating a Clone Object from the Existing Object using the GetDeepCopy method
		var emp2 = emp1.GetDeepCopy();

		// Changing Name and Address Property of Clone Object
		emp2.Name = "Pranaya";
		emp2.EmpAddress.AddressLine1 = "Mumbai";

		Console.WriteLine("Using Deep Copy");
		Console.WriteLine($" Employee 1: Name: {emp1.Name}, Address: {emp1.EmpAddress.AddressLine1}");
		Console.WriteLine($" Employee 2: Name: {emp2.Name}, Address: {emp2.EmpAddress.AddressLine1}");

		// Creating Employee Object
		var emp3 = new Employee
		{
			Name = "Sambit",
			Department = "HR",
			EmpAddress = new Address() { AddressLine1 = "Delhi" }
		};

		// Creating a Clone Object from the Existing Object using the GetShallowCopy method
		var emp4 = emp3.GetShallowCopy();

		//Changing Name and Address Property of Clone Object
		emp4.Name = "Hina";
		emp4.EmpAddress.AddressLine1 = "Hyderabad";

		Console.WriteLine("\nUsing Shallow Copy");
		Console.WriteLine($" Employee 3: Name: {emp3.Name}, Address: {emp3.EmpAddress.AddressLine1}");
		Console.WriteLine($" Employee 4: Name: {emp4.Name}, Address: {emp4.EmpAddress.AddressLine1}");
	}
}
