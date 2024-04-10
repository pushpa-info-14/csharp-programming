namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface
{
    public class UserInterfaceProgram
    {
        public void Test()
        {
            Console.WriteLine("Creating UI for Mobile:");
            var mobileFactory = new MobileUiFactory();
            var mobileUi = new UserInterface(mobileFactory);
            mobileUi.RenderUi();

            Console.WriteLine("Creating UI for Desktop:");
            var desktopFactory = new DesktopUiFactory();
            var desktopUi = new UserInterface(desktopFactory);
            desktopUi.RenderUi();
        }
    }
}
