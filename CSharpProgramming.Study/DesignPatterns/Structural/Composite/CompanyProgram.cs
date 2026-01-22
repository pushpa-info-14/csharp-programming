namespace CSharpProgramming.Study.DesignPatterns.Structural.Composite;

public class CompanyProgram
{
	// The Base Component Abstract class declares the common operations for both Leaf and Composite objects.
	public abstract class Component
	{
		// This Property is used to store the Component Name
		public string Name { get; }

		// Initializing the Name Property using Class Parameterized Constructor
		public Component(string name)
		{
			Name = name;
		}

		// The following GetSalary method is going to be overridden in both Leaf and Composite classes
		public abstract int GetSalary();
	}

	// This is going to be our Leaf class that represents the actual end objects.
	// A leaf Component can not have any children components.
	// The Leaf object is the Object which does the actual work
	public class Leaf : Component
	{
		// The following Property is going to hold the salary of the Employee
		public int Salary { get; }

		// While creating the Leaf Object,
		// we need to pass the Name and the Salary of the Employee
		// The Employee Name we need to pass to the Base class constructor
		// Initializing the Salary Property using the Constructor
		public Leaf(string name, int salary) : base(name)
		{
			Salary = salary;
		}

		// We need to override the following GetSalary method to provide the actual implementation
		public override int GetSalary()
		{
			// We are Printing the Name and Salary of the Employee and then returning the Salary
			Console.WriteLine($"\t Name: {Name} and Salary: {Salary}");
			return Salary;
		}
	}

	// This is going to be a class that represents the Composite Component. 
	// A Composite Object is an Object which has Child Component. 
	// The Children Component Can be a Leaf Object or Can be another Composite Object
	// The Composite object delegate the actual work to their children and then combines the result.
	public class Composite : Component
	{
		// The Following ChildComponents variable is going to hold all the child components of a composite object
		private readonly List<Component> _childComponents = new();

		// The Constructor takes the Composite Component name as the input parameter 
		// and passed that parameter value to the base class constructor
		public Composite(string name) : base(name)
		{
		}

		// The following Method is used to add Child Components inside the Composite Component
		public void AddComponent(Component NewComponent)
		{
			_childComponents.Add(NewComponent);
		}

		// The following Method is used to Remove Child Components from the Composite Component
		public void RemoveComponent(Component RemoveComponent)
		{
			_childComponents.Remove(RemoveComponent);
		}

		// Override the Component class GetSalary Method
		public override int GetSalary()
		{
			// Summarizing the Salary of all children
			return _childComponents.Sum(x => x.GetSalary());
		}
	}

	public void Test()
	{
		// The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. Component.
		// Component means the class that implements the Component abstract class
		// In our example Leaf and Composite classes implement the Component abstract class
		// Creating Leaf Objects or you can say child objects
		Component pranaya = new Leaf("Pranaya", 22000);
		Component rohit = new Leaf("Rohit", 33000);
		Component anurag = new Leaf("Anurag", 42000);
		Component priyanka = new Leaf("Priyanka", 52000);
		Component sambit = new Leaf("Sambit", 28000);

		// Creating Composite Objects
		var itDepartment = new Composite("ITDepartment");
		var hrDepartment = new Composite("HRDepartment");
		var company = new Composite("Company");

		// Creating Tree Structure i.e. Adding Child Components inside the Composite Component
		// Adding Pranaya, Rohit, and Anurag to ITDepartment Composite Object
		itDepartment.AddComponent(pranaya);
		itDepartment.AddComponent(rohit);
		itDepartment.AddComponent(anurag);

		// Adding Priyanka and Sambit in HRDepartment Composite Object
		hrDepartment.AddComponent(priyanka);
		hrDepartment.AddComponent(sambit);

		// Adding ITDepartment and HRDepartment inside Company Composite Object
		company.AddComponent(itDepartment);
		company.AddComponent(hrDepartment);
		Console.WriteLine("All Employees of the Company");

		// To Display the Price of the Computer i.e. it will display the Price of all components
		Console.WriteLine($"Total Salary of the Company: {company.GetSalary()}");

		// To display Salaries and Employees of the IT Department
		Console.WriteLine("\nIT Department Employees");
		Console.WriteLine($"Total Salary of IT Department: {itDepartment.GetSalary()}");

		// To display Salaries and Employees of the HR Department
		Console.WriteLine("\nHR Department Employees");
		Console.WriteLine($"Total Salary of HR Department: {hrDepartment.GetSalary()}");

		// To display Salaries and Employees of HR Department
		Console.WriteLine("\nSalary of Employee Pranaya:");
		pranaya.GetSalary();
		Console.WriteLine($"\nSalary of Employee Anurag: ");
		anurag.GetSalary();
	}
}
