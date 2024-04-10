namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class Mp3Mp4Factory : IMediaFactory
{
    public IAudioProcessor CreateAudioProcessor() => new Mp3Processor();
    public IVideoProcessor CreateVideoProcessor() => new Mp4Processor();
}