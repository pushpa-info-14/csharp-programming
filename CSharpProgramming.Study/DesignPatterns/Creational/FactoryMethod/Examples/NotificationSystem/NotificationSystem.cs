namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class NotificationSystem
    {
        public void NotifyUser(NotifierFactory factory, string message)
        {
            var notifier = factory.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}
