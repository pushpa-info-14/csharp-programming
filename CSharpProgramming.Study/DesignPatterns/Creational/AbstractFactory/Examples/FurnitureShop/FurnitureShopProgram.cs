namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop
{
    public class FurnitureShopProgram
    {
        public void Test()
        {
            Console.WriteLine("Order for Modern Furniture:");
            var modernFactory = new ModernFurnitureFactory();
            var modernShop = new FurnitureShop(modernFactory);
            modernShop.ShowProducts();

            Console.WriteLine("Order for Vintage Furniture:");
            var vintageFactory = new VintageFurnitureFactory();
            var vintageShop = new FurnitureShop(vintageFactory);
            vintageShop.ShowProducts();
        }
    }
}
