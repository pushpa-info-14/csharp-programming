namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ASimpleSystemToHandleNotifications
{
    public class PushNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending PUSH notification: {message}");
            // Logic to send push notification here...
        }
    }
}
