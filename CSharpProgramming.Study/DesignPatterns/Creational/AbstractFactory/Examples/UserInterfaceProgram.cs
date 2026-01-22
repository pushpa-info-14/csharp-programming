namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;

public class UserInterfaceProgram
{
	// Abstract Products
	public interface IButton
	{
		void Render();
	}

	public interface IMenu
	{
		void Display();
	}

	// Concrete Products for Mobile
	public class MobileButton : IButton
	{
		public void Render()
		{
			Console.WriteLine("Rendering a mobile button.");
		}
	}

	public class MobileMenu : IMenu
	{
		public void Display()
		{
			Console.WriteLine("Displaying a mobile menu.");
		}
	}

	// Concrete Products for Desktop
	public class DesktopButton : IButton
	{
		public void Render()
		{
			Console.WriteLine("Rendering a desktop button.");
		}
	}

	public class DesktopMenu : IMenu
	{
		public void Display()
		{
			Console.WriteLine("Displaying a desktop menu.");
		}
	}

	// Abstract Factory
	public interface IUiFactory
	{
		IButton CreateButton();

		IMenu CreateMenu();
	}

	// Concrete Factories
	public class MobileUiFactory : IUiFactory
	{
		public IButton CreateButton() => new MobileButton();

		public IMenu CreateMenu() => new MobileMenu();
	}

	public class DesktopUiFactory : IUiFactory
	{
		public IButton CreateButton() => new DesktopButton();

		public IMenu CreateMenu() => new DesktopMenu();
	}

	// Client Code
	public class UserInterface
	{
		private readonly IButton _button;
		private readonly IMenu _menu;

		public UserInterface(IUiFactory factory)
		{
			_button = factory.CreateButton();
			_menu = factory.CreateMenu();
		}

		public void RenderUi()
		{
			_button.Render();
			_menu.Display();
		}
	}

	public static void Test()
	{
		Console.WriteLine("Creating Ui for Mobile:");
		var mobileFactory = new MobileUiFactory();
		var mobileUi = new UserInterface(mobileFactory);
		mobileUi.RenderUi();

		Console.WriteLine("Creating Ui for Desktop:");
		var desktopFactory = new DesktopUiFactory();
		var desktopUi = new UserInterface(desktopFactory);
		desktopUi.RenderUi();
	}
}
