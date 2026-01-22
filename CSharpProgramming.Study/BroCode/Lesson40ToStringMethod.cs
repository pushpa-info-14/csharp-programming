namespace CSharpProgramming.Study.BroCode
{
	public class Lesson40ToStringMethod
	{
		public void Method1()
		{
			var car = new Car("Chevy", "Corvette", 2022, "blue");

			Console.WriteLine(car.ToString());
		}

		class Car
		{
			public string Make;
			public string Model;
			public int Year;
			public string Color;

			public Car(string make, string model, int year, string color)
			{
				Make = make;
				Model = model;
				Year = year;
				Color = color;
			}

			public override string ToString()
			{
				return $"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}";
			}
		}
	}
}
