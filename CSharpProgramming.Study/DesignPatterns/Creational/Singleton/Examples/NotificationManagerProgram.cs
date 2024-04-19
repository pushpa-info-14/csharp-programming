namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples
{
    public class NotificationManagerProgram
    {
        public sealed class NotificationManager
        {
            // Static instance for Singleton
            private static readonly NotificationManager Instance = new();

            // List to hold notifications
            private readonly List<string> _notifications;

            // Private constructor to prevent external instantiation
            private NotificationManager()
            {
                _notifications = new List<string>();
            }

            // Public method to add a notification
            public void AddNotification(string message)
            {
                _notifications.Add(message);
                // Optionally, you could trigger an event or update a UI element here
            }

            // Public method to retrieve all notifications
            public IEnumerable<string> GetNotifications()
            {
                return _notifications.AsReadOnly();
            }

            // Public method to clear notifications
            public void ClearNotifications()
            {
                _notifications.Clear();
            }

            // Public property to access the Singleton instance
            public static NotificationManager GetInstance()
            {
                return Instance;
            }
        }

        // Client Code
        public void Test()
        {
            // Add a notification
            NotificationManager.GetInstance().AddNotification("Low disk space!");

            // Fetch notifications to display or process
            var currentNotifications = NotificationManager.GetInstance().GetNotifications();
            Console.WriteLine(string.Join(",", currentNotifications));
        }
    }
}
