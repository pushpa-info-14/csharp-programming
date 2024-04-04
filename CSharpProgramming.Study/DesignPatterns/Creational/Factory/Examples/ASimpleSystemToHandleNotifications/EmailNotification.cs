namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ASimpleSystemToHandleNotifications
{
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending EMAIL notification: {message}");
            // Logic to send email here...
        }
    }
}
