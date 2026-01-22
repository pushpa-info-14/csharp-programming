namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;

public class CrossPlatformApplicationProgram
{
	public interface IButton
	{
		void Click();
	}

	public interface ITextBox
	{
		void Write(string text);
	}

	public class WindowsButton : IButton
	{
		public void Click()
		{
			Console.WriteLine("Windows Button Clicked");
		}
	}

	public class WindowsTextBox : ITextBox
	{
		public void Write(string text)
		{
			Console.WriteLine($"Text Written in Windows TextBox: {text}");
		}
	}

	public class MacOsButton : IButton
	{
		public void Click()
		{
			Console.WriteLine("MacOS Button Clicked");
		}
	}

	public class MacOsTextBox : ITextBox
	{
		public void Write(string text)
		{
			Console.WriteLine($"Text Written in MacOS TextBox: {text}");
		}
	}

	public interface IUiFactory
	{
		IButton CreateButton();

		ITextBox CreateTextBox();
	}

	public class WindowsUiFactory : IUiFactory
	{
		public IButton CreateButton() => new WindowsButton();

		public ITextBox CreateTextBox() => new WindowsTextBox();
	}

	public class MacOsUiFactory : IUiFactory
	{
		public IButton CreateButton() => new MacOsButton();

		public ITextBox CreateTextBox() => new MacOsTextBox();
	}

	public class CrossPlatformApplication
	{
		private readonly IButton _button;
		private readonly ITextBox _textBox;

		public CrossPlatformApplication(IUiFactory factory)
		{
			_button = factory.CreateButton();
			_textBox = factory.CreateTextBox();
		}

		public void Render()
		{
			_button.Click();
			_textBox.Write("Sample Text");
		}
	}

	public static void Test()
	{
		IUiFactory factory;
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			factory = new WindowsUiFactory();
		}
		else
		{
			factory = new MacOsUiFactory();
		}
		var app = new CrossPlatformApplication(factory);
		app.Render();
	}
}
