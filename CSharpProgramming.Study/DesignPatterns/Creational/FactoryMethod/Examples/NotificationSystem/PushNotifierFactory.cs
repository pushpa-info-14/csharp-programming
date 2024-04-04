namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
