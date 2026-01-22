namespace CSharpProgramming.Study.BroCode
{
	public class Lesson46AutoImplementedProperties
	{
		public void Method1()
		{
			// Auto-Implemented properties - Shortcut when np additional logic is required in the property.
			//                               You do not have to define a field for a property.
			//                               You only have to write get; and/or set; inside the property.

			var car = new Car(10);

			car.Speed = 1000;

			Console.WriteLine(car.Speed);
		}

		class Car
		{
			public int Speed { get; set; }

			public Car(int speed)
			{
				Speed = speed;
			}
		}
	}
}
