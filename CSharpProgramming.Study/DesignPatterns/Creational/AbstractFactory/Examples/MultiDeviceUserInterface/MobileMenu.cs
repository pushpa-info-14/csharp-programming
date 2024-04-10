namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class MobileMenu : IMenu
{
    public void Display()
    {
        Console.WriteLine("Displaying a mobile menu.");
    }
}