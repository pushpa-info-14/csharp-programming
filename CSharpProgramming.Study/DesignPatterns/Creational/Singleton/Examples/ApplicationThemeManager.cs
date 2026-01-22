namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;

public class ApplicationThemeManager
{
	public sealed class ThemeManager
	{
		// Static instance for Singleton
		private static readonly ThemeManager Instance = new();

		// Properties representing theme settings
		public string BackgroundColor { get; private set; }

		public string FontColor { get; private set; }

		public string FontFamily { get; private set; }

		// ... Other theme-related properties ...

		// Private constructor to prevent external instantiation
		private ThemeManager()
		{
			// Default theme settings
			BackgroundColor = "White";
			FontColor = "Black";
			FontFamily = "Arial";
		}

		// Public method to update theme
		public void UpdateTheme(string backgroundColor, string fontColor, string fontFamily)
		{
			BackgroundColor = backgroundColor;
			FontColor = fontColor;
			FontFamily = fontFamily;
			// ... Update other properties ...

			// Optionally, notify other parts of the application about the theme change
			// using events, observers, etc.
		}

		// Public property to access the Singleton instance
		public static ThemeManager GetInstance()
		{
			return Instance;
		}
	}

	// Client Code
	public static void Test()
	{
		// Set a new theme
		ThemeManager.GetInstance().UpdateTheme("DarkGray", "White", "Calibri");

		// Access theme settings from anywhere in the app
		var currentFont = ThemeManager.GetInstance().FontFamily;
		Console.WriteLine(currentFont);
	}
}
