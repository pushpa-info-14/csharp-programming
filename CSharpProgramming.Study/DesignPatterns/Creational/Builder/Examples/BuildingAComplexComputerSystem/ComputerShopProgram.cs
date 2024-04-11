namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingAComplexComputerSystem
{
    public class ComputerShopProgram
    {
        public void Test()
        {
            ComputerShop shop = new ComputerShop();
            ComputerBuilder builder = new GamingComputerBuilder();

            shop.ConstructComputer(builder);

            Computer computer = builder.GetComputer();
            computer.DisplaySpecifications();
        }
    }
}
