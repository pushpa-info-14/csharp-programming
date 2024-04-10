namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment
{
    public class CrossPlatformApplicationProgram
    {
        public void Test()
        {
            IUiFactory factory;
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                factory = new WindowsUiFactory();
            }
            else
            {
                factory = new MacOsUiFactory();
            }
            var app = new CrossPlatformApplication(factory);
            app.Render();
        }
    }
}
