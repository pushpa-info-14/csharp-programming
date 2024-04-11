namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingAComplexComputerSystem;

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