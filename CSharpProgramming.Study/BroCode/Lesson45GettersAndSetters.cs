namespace CSharpProgramming.Study.BroCode
{
	public class Lesson45GettersAndSetters
	{
		public void Method1()
		{
			// getters & setters - Add security to fields by encapsulation
			//                     They are accessors found within properties

			// properties - Combine aspects of both fields and methods (share name with a field)
			// get accessor - Used to return the property value
			// set accessor - Used to assign a new value
			// value keyword - Defines the value being assigned by the set (parameter)

			var car = new Car(10);

			car.Speed = 1000;

			Console.WriteLine(car.Speed);
		}

		class Car
		{
			private int _speed;

			public Car(int speed)
			{
				_speed = speed;
			}

			public int Speed
			{
				get { return _speed; } // readable
				set // writable
				{
					_speed = value > 500 ? 500 : value;
				}
			}
		}
	}
}
