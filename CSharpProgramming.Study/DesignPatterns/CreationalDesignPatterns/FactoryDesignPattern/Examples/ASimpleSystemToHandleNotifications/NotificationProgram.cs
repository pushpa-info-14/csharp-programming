namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.ASimpleSystemToHandleNotifications
{
    public class NotificationProgram
    {
        public void Test()
        {
            var notificationSender = NotificationFactory.CreateNotificationSender("email");
            notificationSender.SendNotification("This is an email notification!");

            notificationSender = NotificationFactory.CreateNotificationSender("sms");
            notificationSender.SendNotification("This is an SMS notification!");

            notificationSender = NotificationFactory.CreateNotificationSender("push");
            notificationSender.SendNotification("This is a push notification!");

            // As with other factory examples, adding new notification methods 
            // would only require extending the factory, without altering the client code.
        }
    }
}
