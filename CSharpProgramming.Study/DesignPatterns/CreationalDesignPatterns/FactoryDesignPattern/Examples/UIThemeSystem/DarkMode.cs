namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.UIThemeSystem
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
