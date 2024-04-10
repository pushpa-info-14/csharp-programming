namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class AviProcessor : IVideoProcessor
{
    public void ProcessVideo(string file)
    {
        Console.WriteLine($"Processing AVI video file: {file}");
    }
}