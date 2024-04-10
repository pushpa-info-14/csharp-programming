namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class WavProcessor : IAudioProcessor
{
    public void ProcessAudio(string file)
    {
        Console.WriteLine($"Processing WAV audio file: {file}");
    }
}