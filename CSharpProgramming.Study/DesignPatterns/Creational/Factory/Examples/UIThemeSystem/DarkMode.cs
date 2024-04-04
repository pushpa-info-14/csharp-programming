namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.UIThemeSystem
{
    public class DarkMode : ITheme
    {
        public string BackgroundColor => "#000000";
        public string TextColor => "#FFFFFF";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Dark Mode...");
            // Logic for applying dark theme elements
        }
    }
}
