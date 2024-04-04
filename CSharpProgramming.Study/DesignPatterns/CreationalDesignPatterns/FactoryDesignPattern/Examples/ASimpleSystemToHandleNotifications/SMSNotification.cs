namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.ASimpleSystemToHandleNotifications
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
