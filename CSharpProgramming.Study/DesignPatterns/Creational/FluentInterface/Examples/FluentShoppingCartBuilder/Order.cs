namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentShoppingCartBuilder;

public class Order
{
    public List<Product> Products { get; } = new List<Product>();
    public decimal TotalPrice => Products.Sum(p => p.Price);
    public Order AddProduct(Product product)
    {
        Products.Add(product);
        return this;
    }
    public Order RemoveProduct(Product product)
    {
        Products.Remove(product);
        return this;
    }
}