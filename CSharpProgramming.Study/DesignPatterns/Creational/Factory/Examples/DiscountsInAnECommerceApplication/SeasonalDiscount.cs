namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
    internal class SeasonalDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.90m; // 10% seasonal discount
        }
    }
}
