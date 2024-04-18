namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype
{
    public class ShallowCopyExample
    {
        public void Test()
        {
            // Creating an Instance of Employee Class
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";

            // Instead of using Assignment Operator, now use the Clone method to create a Cloned Object
            // Both emp1 and emp2 having different Memory Address
            Employee emp2 = emp1.GetClone();

            // Changing the Name Property Value of emp2 instance, 
            // will not change the Name Property Value of emp1 instance
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

            public Employee GetClone()
            {
                // MemberwiseClone Method Creates a shallow copy of the current System.Object
                // So typecast the Object Appropriate Type
                // In this case, typecast to Employee type
                return (Employee)this.MemberwiseClone();
            }

            // Points to Remember about the MemberwiseClone Method in C#:
            // 1. The MemberwiseClone method is part of the System.Object class and creates a shallow copy of the given object. 
            // 2. MemberwiseClone Method only copies the non-static fields of the object to the new object.
            // 3. If a field is a value type, a bit-by-bit copy of the field is performed.
            // 4. If a field is a reference type, the reference is copied, but the referenced object is not.
        }
    }
}