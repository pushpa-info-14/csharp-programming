namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class MobileUiFactory : IUiFactory
{
    public IButton CreateButton() => new MobileButton();
    public IMenu CreateMenu() => new MobileMenu();
}