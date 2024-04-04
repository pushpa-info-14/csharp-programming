namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.UIThemeSystem
{
    public static class ThemeFactory
    {
        public static ITheme CreateTheme(string themeName)
        {
            switch (themeName.ToLower())
            {
                case "dark":
                    return new DarkMode();
                case "light":
                    return new LightMode();
                case "blue":
                    return new BlueMode();
                default:
                    throw new ArgumentException("Invalid theme specified");
            }
        }
    }
}
