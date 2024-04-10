namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Institution
{
    // The AbstractProductB interface
    // Each distinct product of the Source product family should have a base interface.
    // All variants of Source products must implement this ISource interface.
    public interface ISource
    {
        string GetSourceName();
    }
}
