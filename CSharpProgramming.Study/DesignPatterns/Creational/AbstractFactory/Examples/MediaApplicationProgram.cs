namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;

public class MediaApplicationProgram
{
	// Abstract Products
	public interface IAudioProcessor
	{
		void ProcessAudio(string file);
	}

	public interface IVideoProcessor
	{
		void ProcessVideo(string file);
	}

	// Concrete Products for Mp3 & Mp4
	public class Mp3Processor : IAudioProcessor
	{
		public void ProcessAudio(string file)
		{
			Console.WriteLine($"Processing Mp3 audio file: {file}");
		}
	}

	public class Mp4Processor : IVideoProcessor
	{
		public void ProcessVideo(string file)
		{
			Console.WriteLine($"Processing Mp4 video file: {file}");
		}
	}

	// Concrete Products for Wav & Avi
	public class WavProcessor : IAudioProcessor
	{
		public void ProcessAudio(string file)
		{
			Console.WriteLine($"Processing Wav audio file: {file}");
		}
	}

	public class AviProcessor : IVideoProcessor
	{
		public void ProcessVideo(string file)
		{
			Console.WriteLine($"Processing Avi video file: {file}");
		}
	}

	// Abstract Factory
	public interface IMediaFactory
	{
		IAudioProcessor CreateAudioProcessor();

		IVideoProcessor CreateVideoProcessor();
	}

	// Concrete Factories
	public class Mp3Mp4Factory : IMediaFactory
	{
		public IAudioProcessor CreateAudioProcessor() => new Mp3Processor();

		public IVideoProcessor CreateVideoProcessor() => new Mp4Processor();
	}

	public class WavAviFactory : IMediaFactory
	{
		public IAudioProcessor CreateAudioProcessor() => new WavProcessor();

		public IVideoProcessor CreateVideoProcessor() => new AviProcessor();
	}

	// Client Code
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

	public static void Test()
	{
		Console.WriteLine("Using Mp3 & Mp4 formats:");
		var mp3Mp4Factory = new Mp3Mp4Factory();
		var mp3Mp4App = new MediaApplication(mp3Mp4Factory);
		mp3Mp4App.Run("song.mp3", "video.mp4");

		Console.WriteLine("Using Wav & Avi formats:");
		var wavAviFactory = new WavAviFactory();
		var wavAviApp = new MediaApplication(wavAviFactory);
		wavAviApp.Run("song.wav", "video.avi");
	}
}
