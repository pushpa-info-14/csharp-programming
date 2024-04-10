namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public interface IUiFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
