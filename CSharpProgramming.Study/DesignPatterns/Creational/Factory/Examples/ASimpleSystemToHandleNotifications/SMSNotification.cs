namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ASimpleSystemToHandleNotifications
{
    public class SmsNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
            // Logic to send SMS here...
        }
    }
}
