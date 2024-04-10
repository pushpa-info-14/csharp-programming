namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class MacOsUiFactory : IUiFactory
    {
        public IButton CreateButton() => new MacOsButton();
        public ITextBox CreateTextBox() => new MacOsTextBox();
    }
}
