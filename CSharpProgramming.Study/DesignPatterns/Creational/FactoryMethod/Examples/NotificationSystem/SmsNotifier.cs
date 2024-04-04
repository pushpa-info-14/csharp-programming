namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class SmsNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            // Actual SMS sending logic goes here...
        }
    }
}
