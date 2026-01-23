namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O1_VirtualProxy;

public class ImageLoaderProgram
{
	// The Subject interface declares common operations for both RealSubject and the Proxy. 
	// As long as the client works with RealSubject using this interface, 
	// you will be able to pass it a proxy instead of a real subject.
	public interface IImage
	{
		void DisplayImage();
	}

	// The RealSubject contains some core business logic. 
	// Usually, RealSubjects are capable of doing some useful work which may be very slow or sensitive 
	// A Proxy can solve these issues without any changes to the RealSubject's code.
	public class RealImage : IImage
	{
		private string Filename { get; set; }

		public RealImage(string filename)
		{
			Filename = filename;
			LoadImageFromDisk();
		}

		public void LoadImageFromDisk()
		{
			Console.WriteLine("Loading Image : " + Filename);
		}

		public void DisplayImage()
		{
			Console.WriteLine("Displaying Image : " + Filename);
		}
	}

	// The Proxy has an interface identical to the RealSubject.
	public class ProxyImage : IImage
	{
		private RealImage? realImage = null;
		private string Filename { get; set; }

		public ProxyImage(string filename)
		{
			Filename = filename;
		}

		public void DisplayImage()
		{
			realImage ??= new RealImage(Filename);
			realImage.DisplayImage();
		}
	}

	public static void Test()
	{
		var image1 = new ProxyImage("Tiger Image");
		Console.WriteLine("Image1 calling DisplayImage first time :");
		image1.DisplayImage(); // loading necessary
		Console.WriteLine("Image1 calling DisplayImage second time :");
		image1.DisplayImage(); // loading unnecessary
		Console.WriteLine("Image1 calling DisplayImage third time :");
		image1.DisplayImage(); // loading unnecessary
		Console.WriteLine();

		var image2 = new ProxyImage("Lion Image");
		Console.WriteLine("Image2 calling DisplayImage first time :");
		image2.DisplayImage(); // loading necessary
		Console.WriteLine("Image2 calling DisplayImage second time :");
		image2.DisplayImage(); // loading unnecessary
	}
}
