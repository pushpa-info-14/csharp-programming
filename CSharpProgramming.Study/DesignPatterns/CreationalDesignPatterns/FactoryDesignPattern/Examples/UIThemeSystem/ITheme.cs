namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.UIThemeSystem
{
    public interface ITheme
    {
        string BackgroundColor { get; }
        string TextColor { get; }
        void ApplyTheme();
    }
}
