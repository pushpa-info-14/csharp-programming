namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public interface IMediaFactory
{
    IAudioProcessor CreateAudioProcessor();
    IVideoProcessor CreateVideoProcessor();
}