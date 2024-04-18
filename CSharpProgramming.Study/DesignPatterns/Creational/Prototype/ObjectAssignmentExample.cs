namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype
{
    public class ObjectAssignmentExample
    {
        public void Test()
        {
            // Creating an Instance of Employee Class
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";

            // Creating another Instance of Employee with Existing Employee Instance using Assignment Operator
            // Both emp1 and emp2 share the same memory location as = Operator uses Call By Reference Mechanism
            Employee emp2 = emp1;

            // Changing the Name Property Value of emp2 instance, 
            // it will also change the Name Property Value of emp1 instance
            emp2.Name = "Pranaya";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
        }

        private class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
        }
    }
}
