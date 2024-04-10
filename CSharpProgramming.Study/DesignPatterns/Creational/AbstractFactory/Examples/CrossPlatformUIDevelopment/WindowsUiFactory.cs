namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class WindowsUiFactory : IUiFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextBox CreateTextBox() => new WindowsTextBox();
    }
}
