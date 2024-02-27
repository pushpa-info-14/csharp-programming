namespace CSharpProgramming.Tests.DesignPatterns.Factory
{
    public class Factory
    {
        [Test]
        public void Test1()
        {
            new NavigationBar();
            new DropDownMenu();
        }

        internal class NavigationBar
        {
            public NavigationBar() => ButtonFactory.CreateButton();
        }

        internal class DropDownMenu
        {
            public DropDownMenu() => ButtonFactory.CreateButton();
        }

        internal static class ButtonFactory
        {
            public static Button CreateButton()
            {
                return new Button { Type = "Default Button" };
            }
        }

        internal class Button
        {
            public string Type { get; set; }
        }
    }
}
