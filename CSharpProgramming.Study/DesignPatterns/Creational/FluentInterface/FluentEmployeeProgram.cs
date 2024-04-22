﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface
{
    public class FluentEmployeeProgram
    {
        public class Employee
        {
            public string? FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? Department { get; set; }
            public string? Address { get; set; }
        }

        public class FluentEmployee
        {
            private readonly Employee _employee = new();

            public FluentEmployee NameOfTheEmployee(string fullName)
            {
                _employee.FullName = fullName;
                return this;
            }

            public FluentEmployee Born(string dateOfBirth)
            {
                _employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
                return this;
            }

            public FluentEmployee WorkingOn(string department)
            {
                _employee.Department = department;
                return this;
            }

            public FluentEmployee StaysAt(string address)
            {
                _employee.Address = address;
                return this;
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Name: {_employee.FullName}, \nDateOfBirth: {_employee.DateOfBirth}, \nDepartment: {_employee.Department}, \nAddress: {_employee.Address}");
            }
        }

        public void Test()
        {
            // Create an Instance of Wrapper class i.e. FluentEmployee
            FluentEmployee obj = new();

            // Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("Pushpa Kumara")
                .Born("10/10/1992")
                .WorkingOn("IT")
                .StaysAt("Sri Lanka");

            // To See the Details call the ShowDetails Method
            obj.ShowDetails();
        }
    }
}