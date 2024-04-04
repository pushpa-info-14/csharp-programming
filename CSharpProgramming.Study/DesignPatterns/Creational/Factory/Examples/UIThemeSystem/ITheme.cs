namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.UIThemeSystem
{
    public interface ITheme
    {
        string BackgroundColor { get; }
        string TextColor { get; }
        void ApplyTheme();
    }
}
