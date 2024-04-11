namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingAComplexComputerSystem;

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