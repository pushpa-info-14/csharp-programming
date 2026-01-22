namespace CSharpProgramming.Study.General
{
	public class SampleStack
	{
		public void Test()
		{

			// Creates and initializes a new Stack.
			Stack<string> stack = new Stack<string>();
			stack.Push("Hello");
			stack.Push("World");
			stack.Push("!");

			// Displays the properties and values of the Stack.
			Console.WriteLine("myStack");
			Console.WriteLine("\tCount :{0}", stack.Count);
			Console.Write("\tValues:");
			PrintValues(stack);
		}

		private void PrintValues(Stack<string> stack)
		{
			foreach (var obj in stack)
				Console.Write("{0} ", obj);
			Console.WriteLine();
		}
	}
}
