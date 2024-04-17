﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Employee;

public class PermanentEmployee : Employee
{
    public int Salary { get; set; }
    public override Employee GetClone()
    {
        // MemberwiseClone Method Creates a shallow copy of the current System.Object
        // So typecast the Object Appropriate Type
        // In this case, typecast to PermanentEmployee type
        return (PermanentEmployee)this.MemberwiseClone();
    }
    public override void ShowDetails()
    {
        Console.WriteLine("Permanent Employee");
        Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
    }
}