namespace CSharpProgramming.Tests.DesignPatterns.Factory
{
	public class AbstractFactory
	{
		[Test]
		public void Test1()
		{
			new NavigationBar(new Apple());
			new DropDownMenu(new Apple());
		}

		internal class NavigationBar
		{
			public NavigationBar(IUIFactory factory) => factory.CreateButton();
		}

		internal class DropDownMenu
		{
			public DropDownMenu(IUIFactory factory) => factory.CreateButton();
		}

		internal interface IUIFactory
		{
			public Button CreateButton();
		}

		internal class Apple : IUIFactory
		{
			public Button CreateButton()
			{
				return new Button { Type = "IOS Button" };
			}
		}

		internal class Android : IUIFactory
		{
			public Button CreateButton()
			{
				return new Button { Type = "Android Button" };
			}
		}

		internal class Button
		{
			public string Type { get; set; }
		}
	}
}
