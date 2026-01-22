namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype.Examples;

public class EventManagement
{
	// Prototype - ISchedulePrototype Interface
	private interface ISchedulePrototype
	{
		ISchedulePrototype Clone();
	}

	// Concrete Prototype - ConferenceSchedule Class
	private class ConferenceSchedule : ISchedulePrototype
	{
		public List<string> Sessions { get; set; } = new();

		public List<string> Speakers { get; set; } = new();

		public ISchedulePrototype Clone()
		{
			// Deep copying is important here since Lists are reference types.
			return new ConferenceSchedule
			{
				Sessions = new List<string>(Sessions),
				Speakers = new List<string>(Speakers)
			};
		}

		public void DisplaySchedule()
		{
			Console.WriteLine("Conference Schedule:");
			for (int i = 0; i < Sessions.Count; i++)
			{
				Console.WriteLine($"Session {i + 1}: {Sessions[i]} by {Speakers[i]}");
			}
			Console.WriteLine();
		}
	}

	// Client Code
	public static void Test()
	{
		// Standard conference schedule template
		var standardSchedule = new ConferenceSchedule
		{
			Sessions = { "Welcome Note", "Tech Trends", "Networking Session" },
			Speakers = { "Host", "Tech Guru", "All Participants" }
		};

		Console.WriteLine("Standard Schedule:");
		standardSchedule.DisplaySchedule();

		// A client wants a similar schedule but with an added "Innovation Talk".
		var customSchedule = (ConferenceSchedule)standardSchedule.Clone();
		customSchedule.Sessions.Insert(2, "Innovation Talk");
		customSchedule.Speakers.Insert(2, "Innovation Expert");

		Console.WriteLine("Custom Schedule for Client A:");
		customSchedule.DisplaySchedule();
	}
}
