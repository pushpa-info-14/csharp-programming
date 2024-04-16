namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentShoppingCartBuilder;

public class ShoppingCartBuilder
{
    private readonly Order _order = new();
    public ShoppingCartBuilder AddProduct(string name, decimal price)
    {
        var product = new Product { Name = name, Price = price };
        _order.AddProduct(product);
        return this;
    }
    public ShoppingCartBuilder RemoveProduct(string name)
    {
        var product = _order.Products.Find(p => p.Name == name);
        if (product != null)
        {
            _order.RemoveProduct(product);
        }
        return this;
    }
    public Order Checkout()
    {
        return _order;
    }
}