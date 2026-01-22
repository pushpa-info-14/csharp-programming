namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

public class ThemeProgram
{
	public interface ITheme
	{
		string BackgroundColor { get; }

		string TextColor { get; }

		void ApplyTheme();
	}

	public class LightMode : ITheme
	{
		public string BackgroundColor => "#FFFFFF";

		public string TextColor => "#000000";

		public void ApplyTheme()
		{
			Console.WriteLine("Applying Light Mode...");
			// Logic for applying light theme elements
		}
	}

	public class DarkMode : ITheme
	{
		public string BackgroundColor => "#000000";

		public string TextColor => "#FFFFFF";

		public void ApplyTheme()
		{
			Console.WriteLine("Applying Dark Mode...");
			// Logic for applying dark theme elements
		}
	}

	public class BlueMode : ITheme
	{
		public string BackgroundColor => "#0000FF";

		public string TextColor => "#FFFFFF";

		public void ApplyTheme()
		{
			Console.WriteLine("Applying Blue Mode...");
			// Logic for applying blue theme elements
		}
	}

	public static class ThemeFactory
	{
		public static ITheme CreateTheme(string themeName)
		{
			switch (themeName.ToLower())
			{
				case "dark":
					return new DarkMode();
				case "light":
					return new LightMode();
				case "blue":
					return new BlueMode();
				default:
					throw new ArgumentException("Invalid theme specified");
			}
		}
	}

	public static void Test()
	{
		var theme = ThemeFactory.CreateTheme("Dark");
		theme.ApplyTheme();   // Applying the selected UI theme

		theme = ThemeFactory.CreateTheme("Light");
		theme.ApplyTheme();   // Applying the selected UI theme

		theme = ThemeFactory.CreateTheme("Blue");
		theme.ApplyTheme();   // Applying the selected UI theme
	}
}
