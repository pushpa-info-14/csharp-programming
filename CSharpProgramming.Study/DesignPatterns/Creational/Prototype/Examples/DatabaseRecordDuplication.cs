namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class DatabaseRecordDuplication
    {
        // Prototype - IEmployeePrototype Interface
        public interface IEmployeePrototype
        {
            IEmployeePrototype Clone();
        }

        // Concrete Prototype - EmployeeProfile Class
        public class EmployeeProfile : IEmployeePrototype
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Role { get; set; }
            public decimal Salary { get; set; }

            public IEmployeePrototype Clone()
            {
                return new EmployeeProfile
                {
                    Name = Name,
                    Address = Address,
                    Role = Role,
                    Salary = Salary
                };
            }

            public void DisplayProfile()
            {
                Console.WriteLine($"Name: {Name} | Address: {Address} | Role: {Role} | Salary: ${Salary}");
            }
        }

        // Client Code
        public void Test()
        {
            // Existing employee profile in the HR database
            var existingEmployee = new EmployeeProfile
            {
                Name = "John Doe",
                Address = "123 Main St, Cityville",
                Role = "Software Developer",
                Salary = 75000
            };

            Console.WriteLine("Existing Employee Profile:");
            existingEmployee.DisplayProfile();

            // HR wants to create a profile for a new temporary staff member with a similar role and salary
            var tempEmployee = (EmployeeProfile)existingEmployee.Clone();
            tempEmployee.Name = "Jane Smith";
            tempEmployee.Address = "456 Elm St, Cityville";

            Console.WriteLine("\nNew Temporary Employee Profile:");
            tempEmployee.DisplayProfile();
        }
    }
}
