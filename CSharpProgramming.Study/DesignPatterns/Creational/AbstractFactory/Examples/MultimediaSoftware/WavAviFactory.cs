namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class WavAviFactory : IMediaFactory
{
    public IAudioProcessor CreateAudioProcessor() => new WavProcessor();
    public IVideoProcessor CreateVideoProcessor() => new AviProcessor();
}