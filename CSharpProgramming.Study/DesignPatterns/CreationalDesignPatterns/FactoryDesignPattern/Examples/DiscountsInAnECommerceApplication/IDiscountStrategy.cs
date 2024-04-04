namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DiscountsInAnECommerceApplication
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }
}
