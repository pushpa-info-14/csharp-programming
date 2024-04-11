namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingAComplexComputerSystem;

public class GamingComputerBuilder : ComputerBuilder
{
    public override void SetCpu()
    {
        Computer.CPU = "High Performance CPU";
    }

    public override void SetRam()
    {
        Computer.RAM = "16 GB DDR4";
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