namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;

public class UserInterface
{
    private readonly IButton _button;
    private readonly IMenu _menu;

    public UserInterface(IUiFactory factory)
    {
        _button = factory.CreateButton();
        _menu = factory.CreateMenu();
    }

    public void RenderUi()
    {
        _button.Render();
        _menu.Display();
    }
}