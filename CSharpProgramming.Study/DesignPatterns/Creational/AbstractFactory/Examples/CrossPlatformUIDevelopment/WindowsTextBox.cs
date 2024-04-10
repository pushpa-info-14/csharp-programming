namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class WindowsTextBox : ITextBox
    {
        public void Write(string text)
        {
            Console.WriteLine($"Text Written in Windows TextBox: {text}");
        }
    }
}
