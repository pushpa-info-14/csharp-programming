namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.UIThemeSystem
{
    public class ThemeProgram
    {
        public void Test()
        {
            var theme = ThemeFactory.CreateTheme("Dark");
            theme.ApplyTheme();   // Applying the selected UI theme

            theme = ThemeFactory.CreateTheme("Light");
            theme.ApplyTheme();   // Applying the selected UI theme

            theme = ThemeFactory.CreateTheme("Blue");
            theme.ApplyTheme();   // Applying the selected UI theme
        }
    }
}
