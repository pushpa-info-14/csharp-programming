namespace CSharpProgramming.Study.General
{
	public class SampleQueue
	{
		public void Test()
		{

			// Creates and initializes a new Queue.
			Queue<string> queue = new Queue<string>();
			queue.Enqueue("Hello");
			queue.Enqueue("World");
			queue.Enqueue("!");

			// Displays the properties and values of the Queue.
			Console.WriteLine("myQueue");
			Console.WriteLine("\tCount :{0}", queue.Count);
			Console.Write("\tValues:");
			PrintValues(queue);
		}

		private void PrintValues(Queue<string> queue)
		{
			foreach (var obj in queue)
				Console.Write("{0} ", obj);
			Console.WriteLine();
		}
	}
}
