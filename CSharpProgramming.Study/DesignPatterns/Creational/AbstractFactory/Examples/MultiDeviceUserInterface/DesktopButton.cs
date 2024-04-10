namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class DesktopButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a desktop button.");
    }
}