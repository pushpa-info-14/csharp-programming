namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O4_Bridge;

public class SendMessageProgram
{
	// This is going to be an interface that acts as a bridge between the Abstraction Layer and Implementation Layer
	// The following Implementor Interface defines the operations for all implementation classes.
	// It doesn't have to match the Abstraction's interface. 
	// In fact, the two interfaces can be entirely different. 
	public interface IMessageSender
	{
		void SendMessage(string Message);
	}

	// This is going to be a class that implements the Implementor Interface i.e. IMessageSender
	// It also provides the implementation details for the associated Abstraction class 
	// Each Concrete Implementation corresponds to a specific platform, in this case sending messages using SMS
	public class SmsMessageSender : IMessageSender
	{
		public void SendMessage(string Message)
		{
			// Send a message using SMS
			Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
		}
	}

	// This is going to be a class that implements the Implementor Interface i.e. IMessageSender
	// It also provides the implementation details for the associated Abstraction class 
	// Each Concrete Implementation corresponds to a specific platform, in this case sending messages using Email
	public class EmailMessageSender : IMessageSender
	{
		public void SendMessage(string Message)
		{
			Console.WriteLine("'" + Message + "'   : This Message has been sent using Email");
		}
	}

	// This is an abstract class that going to be implemented by the Concrete Abstraction
	// It contains a reference to an object of type IMessageSender Interface i.e. messageSender
	// and delegates all of the real work to this object (the class that implements IMessageSender Interface).
	// It can also act as the base class for other abstractions.
	public abstract class AbstractMessage
	{
		protected IMessageSender messageSender;
		public abstract void SendMessage(string Message);
	}

	// This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractMessage. 
	// This Concrete Abstraction Class implements the operations defined by AbstractMessage class.
	public class ShortMessage : AbstractMessage
	{
		// The constructor expected an argument of type object which implements the IMessageSender interface
		public ShortMessage(IMessageSender messageSender)
		{
			// Initialize the super class messageSender variable
			this.messageSender = messageSender;
		}
		public override void SendMessage(string Message)
		{
			if (Message.Length <= 10)
			{
				messageSender.SendMessage(Message);
			}
			else
			{
				Console.WriteLine("Unable to send the message as length > 10 characters");
			}
		}
	}

	// This is going to be a concrete class that inherits from the Abstraction class i.e. AbstractMessage. 
	// This Concrete Abstraction Class implements the operations defined by AbstractMessage class.
	public class LongMessage : AbstractMessage
	{
		public LongMessage(IMessageSender messageSender)
		{
			// Initialize the super class messageSender variable
			this.messageSender = messageSender;
		}
		public override void SendMessage(string Message)
		{
			messageSender.SendMessage(Message);
		}
	}

	public void Test()
	{
		// Except for the initialization phase, where an Abstraction object i.e. LongMessage or ShortMessage
		// linked with a specific Implementation object i.e. new EmailMessageSender() or new SmsMessageSender(), 
		// the client code should only depend on the Abstraction class i.e. AbstractMessage
		var random = new Random();
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Select the Message Type 1. For longmessage or 2. For shortmessage");
			var messageType = random.Next(1, 3);

			Console.WriteLine("Please enter the message that you want to send");
			var message = "Sample message";

			if (messageType == 1)
			{
				AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
				longMessage.SendMessage(message);
			}
			else
			{
				AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
				shortMessage.SendMessage(message);
			}
		}
	}
}
