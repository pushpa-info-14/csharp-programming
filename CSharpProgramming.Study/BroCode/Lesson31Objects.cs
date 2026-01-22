namespace CSharpProgramming.Study.BroCode
{
	public class Lesson31Objects
	{
		public void Method1()
		{
			// object - An instance of a class
			//          A class can be used as a blueprint to create objects (OOP)
			//          Objects can have fields & methods (characteristics & actions)


			var human1 = new Human();
			var human2 = new Human();

			human1.Name = "Pushpa";
			human1.Age = 30;
			human1.Eat();
			human1.Sleep();

			human2.Name = "Kumara";
			human2.Age = 37;
			human2.Eat();
			human2.Sleep();
		}

		class Human
		{
			public string Name { get; set; }
			public int Age { get; set; }

			public void Eat()
			{
				Console.WriteLine(Name + " is eating");
			}

			public void Sleep()
			{
				Console.WriteLine(Name + " is sleeping");
			}
		}
	}
}
