namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // Actual push notification logic goes here...
        }
    }
}
