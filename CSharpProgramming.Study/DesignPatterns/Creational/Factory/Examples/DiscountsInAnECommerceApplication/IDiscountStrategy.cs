namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }
}
