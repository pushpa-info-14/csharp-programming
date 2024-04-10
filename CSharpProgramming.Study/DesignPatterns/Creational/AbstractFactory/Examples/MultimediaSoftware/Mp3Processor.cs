namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class Mp3Processor : IAudioProcessor
{
    public void ProcessAudio(string file)
    {
        Console.WriteLine($"Processing MP3 audio file: {file}");
    }
}