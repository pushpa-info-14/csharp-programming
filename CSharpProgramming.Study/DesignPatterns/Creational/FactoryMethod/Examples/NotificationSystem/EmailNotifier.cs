namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
            // Actual email sending logic goes here...
        }
    }
}
