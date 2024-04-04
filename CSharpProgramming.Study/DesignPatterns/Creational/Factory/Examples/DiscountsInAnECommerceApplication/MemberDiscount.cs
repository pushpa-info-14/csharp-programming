namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
    public class MemberDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.95m; // 5% member discount
        }
    }
}
