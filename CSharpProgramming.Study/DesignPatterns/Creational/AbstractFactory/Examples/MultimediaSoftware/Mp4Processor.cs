namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class Mp4Processor : IVideoProcessor
{
    public void ProcessVideo(string file)
    {
        Console.WriteLine($"Processing MP4 video file: {file}");
    }
}