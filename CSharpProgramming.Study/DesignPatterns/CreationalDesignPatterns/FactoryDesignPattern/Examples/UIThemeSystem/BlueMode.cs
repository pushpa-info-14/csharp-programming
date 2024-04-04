namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.UIThemeSystem
{
    public class BlueMode : ITheme
    {
        public string BackgroundColor => "#0000FF";
        public string TextColor => "#FFFFFF";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Blue Mode...");
            // Logic for applying blue theme elements
        }
    }
}
