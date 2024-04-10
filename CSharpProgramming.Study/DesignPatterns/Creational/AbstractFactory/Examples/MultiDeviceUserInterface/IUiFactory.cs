namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public interface IUiFactory
{
    IButton CreateButton();
    IMenu CreateMenu();
}