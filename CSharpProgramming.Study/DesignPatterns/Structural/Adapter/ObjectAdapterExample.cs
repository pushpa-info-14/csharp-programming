namespace CSharpProgramming.Study.DesignPatterns.Structural.Adapter
{
    public class ObjectAdapterExample
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public decimal Salary { get; set; }

            public Employee(int id, string name, string designation, decimal salary)
            {
                Id = id;
                Name = name;
                Designation = designation;
                Salary = salary;
            }
        }

        // The Adaptee contains some functionality that is required by the client.
        // But this interface is not compatible with the client code.
        public class ThirdPartyBillingSystem
        {
            //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
            public void ProcessSalary(List<Employee> listEmployee)
            {
                foreach (var employee in listEmployee)
                {
                    Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
                }
            }
        }

        // The ITarget defines the domain-specific interface used by the client code.
        // This interface needs to be implemented by the Adapter.
        // The client can only see this interface i.e. the class which implements the ITarget interface.
        public interface ITarget
        {
            void ProcessCompanySalary(string[,] employeesArray);
        }

        // This is the class that makes two incompatible interfaces or systems work together.
        // The Adapter makes the Adaptee's interface compatible with the Target's interface.
        public class EmployeeAdapter : ITarget
        {
            // To use Object Adapter Design Pattern, we need to create an object of ThirdPartyBillingSystem
            private readonly ThirdPartyBillingSystem _thirdPartyBillingSystem = new();

            // The following will accept the employees in the form of string array
            // Then convert the employee string array to List of Employees
            // After conversation, it will call the Adaptee's Method to Process the Salaries
            public void ProcessCompanySalary(string[,] employeesArray)
            {
                string id = null;
                string name = null;
                string designation = null;
                string salary = null;

                var listEmployee = new List<Employee>();

                for (var i = 0; i < employeesArray.GetLength(0); i++)
                {
                    for (var j = 0; j < employeesArray.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            id = employeesArray[i, j];
                        }
                        else if (j == 1)
                        {
                            name = employeesArray[i, j];
                        }
                        else if (j == 2)
                        {
                            designation = employeesArray[i, j];
                        }
                        else
                        {
                            salary = employeesArray[i, j];
                        }
                    }

                    listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
                }

                Console.WriteLine("Adapter converted Array of Employee to List of Employee");
                Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
                _thirdPartyBillingSystem.ProcessSalary(listEmployee);
            }
        }

        public void Test()
        {
            // Storing the Employees Data in a string array
            var employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            // The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
        }
    }
}
