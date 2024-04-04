namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
    public class ClearanceDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.70m; // 30% clearance discount
        }
    }
}
