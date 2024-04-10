namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class MacOsTextBox : ITextBox
    {
        public void Write(string text)
        {
            Console.WriteLine($"Text Written in MacOS TextBox: {text}");
        }
    }
}
