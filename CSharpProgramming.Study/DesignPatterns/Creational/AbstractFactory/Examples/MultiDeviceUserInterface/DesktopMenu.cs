namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class DesktopMenu : IMenu
{
    public void Display()
    {
        Console.WriteLine("Displaying a desktop menu.");
    }
}