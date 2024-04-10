namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class MacOsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacOS Button Clicked");
        }
    }
}
