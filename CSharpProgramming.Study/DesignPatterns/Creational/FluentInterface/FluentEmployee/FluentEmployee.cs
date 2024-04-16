namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.FluentEmployee;

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