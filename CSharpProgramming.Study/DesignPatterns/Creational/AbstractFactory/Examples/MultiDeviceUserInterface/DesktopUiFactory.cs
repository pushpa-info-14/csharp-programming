namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class DesktopUiFactory : IUiFactory
{
    public IButton CreateButton() => new DesktopButton();
    public IMenu CreateMenu() => new DesktopMenu();
}