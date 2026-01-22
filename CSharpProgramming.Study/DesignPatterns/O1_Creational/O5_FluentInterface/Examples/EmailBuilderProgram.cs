namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O5_FluentInterface.Examples;

public class EmailBuilderProgram
{
	public class Email
	{
		public string From { get; set; }

		public List<string> To { get; } = new();

		public string Subject { get; set; }

		public string Body { get; set; }

		// ... Additional fields like CC, BCC, Attachments, etc.
	}

	public class EmailBuilder
	{
		private readonly Email _email = new();

		public EmailBuilder From(string sender)
		{
			_email.From = sender;
			return this;
		}

		public EmailBuilder To(string recipient)
		{
			_email.To.Add(recipient);
			return this;
		}

		public EmailBuilder WithSubject(string subject)
		{
			_email.Subject = subject;
			return this;
		}

		public EmailBuilder WithBody(string body)
		{
			_email.Body = body;
			return this;
		}

		public Email Send()  // This would be integrated with an actual sending mechanism in a real-world scenario.
		{
			// Logic to send the email...
			Console.WriteLine($"Sent email to {string.Join(", ", _email.To)} with subject '{_email.Subject}'.");
			return _email;
		}
	}

	public static void Test()
	{
		var email = new EmailBuilder()
			.From("admin@dotnettutorials.net")
			.To("user1@dotnettutorials.net")
			.To("user2@dotnettutorials.net")
			.WithSubject("Welcome to Fluent Builder!")
			.WithBody("This is an example of the Fluent Interface Design Pattern in C#.")
			.Send();
	}
}
