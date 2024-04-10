namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultimediaSoftware
{
    public class MediaApplicationProgram
    {
        public void Test()
        {
            Console.WriteLine("Using MP3 & MP4 formats:");
            var mp3Mp4Factory = new Mp3Mp4Factory();
            var mp3Mp4App = new MediaApplication(mp3Mp4Factory);
            mp3Mp4App.Run("song.mp3", "video.mp4");

            Console.WriteLine("Using WAV & AVI formats:");
            var wavAviFactory = new WavAviFactory();
            var wavAviApp = new MediaApplication(wavAviFactory);
            wavAviApp.Run("song.wav", "video.avi");
        }
    }
}
