namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Employee;

public abstract class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Type { get; set; }
    public abstract Employee GetClone();
    public abstract void ShowDetails();
}