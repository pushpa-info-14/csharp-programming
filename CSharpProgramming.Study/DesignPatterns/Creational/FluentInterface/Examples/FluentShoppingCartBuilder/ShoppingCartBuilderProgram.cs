namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentShoppingCartBuilder
{
    public class ShoppingCartBuilderProgram
    {
        public void Test()
        {
            var order = new ShoppingCartBuilder()
                .AddProduct("Laptop", 1000m)
                .AddProduct("Mouse", 50m)
                .RemoveProduct("Mouse")
                .AddProduct("Keyboard", 70m)
                .Checkout();
            Console.WriteLine($"Total Price: {order.TotalPrice}");
            // Outputs: Total Price: 1070
        }
    }
}
