namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware;

public class MediaApplication
{
    private readonly IAudioProcessor _audioProcessor;
    private readonly IVideoProcessor _videoProcessor;

    public MediaApplication(IMediaFactory factory)
    {
        _audioProcessor = factory.CreateAudioProcessor();
        _videoProcessor = factory.CreateVideoProcessor();
    }

    public void Run(string audioFile, string videoFile)
    {
        _audioProcessor.ProcessAudio(audioFile);
        _videoProcessor.ProcessVideo(videoFile);
    }
}