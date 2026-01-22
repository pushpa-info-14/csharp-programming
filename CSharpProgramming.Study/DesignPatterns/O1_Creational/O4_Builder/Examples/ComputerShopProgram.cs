namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O4_Builder.Examples;

public class ComputerShopProgram
{
	public class Computer
	{
		public string Cpu { get; set; }

		public string Ram { get; set; }

		public string HardDrive { get; set; }

		public string GraphicsCard { get; set; }

		public string SoundCard { get; set; }

		public void DisplaySpecifications()
		{
			Console.WriteLine($"CPU: {Cpu}");
			Console.WriteLine($"RAM: {Ram}");
			Console.WriteLine($"Hard Drive: {HardDrive}");
			Console.WriteLine($"Graphics Card: {GraphicsCard ?? "Not present"}");
			Console.WriteLine($"Sound Card: {SoundCard ?? "Not present"}");
		}
	}

	public abstract class ComputerBuilder
	{
		protected Computer Computer { get; } = new();

		public abstract void SetCpu();

		public abstract void SetRam();

		public abstract void SetHardDrive();

		public virtual void SetGraphicsCard() { } // Optional

		public virtual void SetSoundCard() { }    // Optional

		public Computer GetComputer() => Computer;
	}

	public class GamingComputerBuilder : ComputerBuilder
	{
		public override void SetCpu()
		{
			Computer.Cpu = "High Performance CPU";
		}

		public override void SetRam()
		{
			Computer.Ram = "16 GB DDR4";
		}

		public override void SetHardDrive()
		{
			Computer.HardDrive = "1 TB SSD";
		}

		public override void SetGraphicsCard()
		{
			Computer.GraphicsCard = "High-end Graphics Card";
		}

		public override void SetSoundCard()
		{
			Computer.SoundCard = "7.1 Surround Sound Card";
		}
	}

	public class ComputerShop
	{
		public void ConstructComputer(ComputerBuilder builder)
		{
			builder.SetCpu();
			builder.SetRam();
			builder.SetHardDrive();
			builder.SetGraphicsCard();
			builder.SetSoundCard();
		}
	}

	public static void Test()
	{
		var shop = new ComputerShop();
		ComputerBuilder builder = new GamingComputerBuilder();

		shop.ConstructComputer(builder);

		var computer = builder.GetComputer();
		computer.DisplaySpecifications();
	}
}
