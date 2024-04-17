﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Employee;

public class TemporaryEmployee : Employee
{
    public int FixedAmount { get; set; }
    public override Employee GetClone()
    {
        // MemberwiseClone Method Creates a shallow copy of the current System.Object
        // So typecast the Object Appropriate Type
        // In this case, typecast to TemporaryEmployee type
        return (TemporaryEmployee)this.MemberwiseClone();
    }
    public override void ShowDetails()
    {
        Console.WriteLine("Temporary Employee");
        Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
    }
}