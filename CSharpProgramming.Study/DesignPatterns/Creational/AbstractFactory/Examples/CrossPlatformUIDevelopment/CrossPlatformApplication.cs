namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class CrossPlatformApplication
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;

        public CrossPlatformApplication(IUiFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
        }

        public void Render()
        {
            _button.Click();
            _textBox.Write("Sample Text");
        }
    }
}
