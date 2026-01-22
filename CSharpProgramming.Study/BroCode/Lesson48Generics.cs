namespace CSharpProgramming.Study.BroCode
{
	public class Lesson48Generics
	{
		public void Method1()
		{
			// generics - "Not specific to a particular data type
			//            Add <T> to: classes, methods, fields, etc.
			//            Allows for code re-usability for different data types

			int[] intArray = { 1, 2, 3 };
			double[] doubleArray = { 1, 2, 3 };
			string[] stringArray = { "1", "2", "3" };

			DisplayElements(intArray);
			DisplayElements(doubleArray);
			DisplayElements(stringArray);
		}

		private void DisplayElements<T>(T[] elements)
		{
			foreach (var element in elements)
			{
				Console.WriteLine(element);
			}
		}
	}
}
