namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
