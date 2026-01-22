namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O7_Singleton.Examples;

public class TaskSchedulerProgram
{
	public sealed class TaskScheduler
	{
		// Static instance for Singleton
		private static readonly TaskScheduler Instance = new();

		// Dictionary to hold tasks and their timers
		private readonly Dictionary<string, System.Timers.Timer> _scheduledTasks;

		// Private constructor to prevent external instantiation
		private TaskScheduler()
		{
			_scheduledTasks = new Dictionary<string, System.Timers.Timer>();
		}

		// Public method to schedule a task
		public void ScheduleTask(string taskId, Action taskAction, double intervalInMilliseconds)
		{
			if (_scheduledTasks.ContainsKey(taskId))
			{
				throw new InvalidOperationException($"Task with ID {taskId} is already scheduled.");
			}

			var timer = new System.Timers.Timer(intervalInMilliseconds);
			timer.Elapsed += (sender, e) => taskAction();
			timer.Start();

			_scheduledTasks[taskId] = timer;
		}

		// Public method to stop a scheduled task
		public void StopScheduledTask(string taskId)
		{
			if (_scheduledTasks.TryGetValue(taskId, out var timer))
			{
				timer.Stop();
				_scheduledTasks.Remove(taskId);
			}
		}

		// Public property to access the Singleton instance
		public static TaskScheduler GetInstance()
		{
			return Instance;
		}
	}

	// Client Code
	public static void Test()
	{
		// Schedule a task to run every 5 seconds
		TaskScheduler.GetInstance().ScheduleTask("SampleTask", () => Console.WriteLine("Task executed!"), 5000);

		// Later, stop the task if needed
		TaskScheduler.GetInstance().StopScheduledTask("SampleTask");
	}
}
