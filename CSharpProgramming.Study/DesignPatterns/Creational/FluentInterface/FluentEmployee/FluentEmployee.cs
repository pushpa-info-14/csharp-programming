namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.FluentEmployee;

public class FluentEmployee
{
    private Employee employee = new();

    public FluentEmployee NameOfTheEmployee(string fullName)
    {
        employee.FullName = fullName;
        return this;
    }

    public FluentEmployee Born(string dateOfBirth)
    {
        employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
        return this;
    }

    public FluentEmployee WorkingOn(string department)
    {
        employee.Department = department;
        return this;
    }

    public FluentEmployee StaysAt(string address)
    {
        employee.Address = address;
        return this;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {employee.FullName}, \nDateOfBirth: {employee.DateOfBirth}, \nDepartment: {employee.Department}, \nAddress: {employee.Address}");
    }
}