namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class MobileButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a mobile button.");
    }
}