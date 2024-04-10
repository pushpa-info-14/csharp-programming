namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Windows Button Clicked");
        }
    }
}
