namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O1_Factory.Examples;

public class NotificationProgram
{
	public interface INotificationSender
	{
		void SendNotification(string message);
	}

	public class EmailNotification : INotificationSender
	{
		public void SendNotification(string message)
		{
			Console.WriteLine($"Sending EMAIL notification: {message}");
			// Logic to send email here...
		}
	}

	public class PushNotification : INotificationSender
	{
		public void SendNotification(string message)
		{
			Console.WriteLine($"Sending PUSH notification: {message}");
			// Logic to send push notification here...
		}
	}

	public class SmsNotification : INotificationSender
	{
		public void SendNotification(string message)
		{
			Console.WriteLine($"Sending SMS notification: {message}");
			// Logic to send SMS here...
		}
	}

	public static class NotificationFactory
	{
		public static INotificationSender CreateNotificationSender(string type)
		{
			switch (type.ToLower())
			{
				case "email":
					return new EmailNotification();
				case "sms":
					return new SmsNotification();
				case "push":
					return new PushNotification();
				default:
					throw new ArgumentException("Invalid notification type");
			}
		}
	}

	public static void Test()
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
