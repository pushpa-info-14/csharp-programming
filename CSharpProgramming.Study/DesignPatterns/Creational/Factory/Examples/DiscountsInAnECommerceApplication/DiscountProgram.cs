namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
    public class DiscountProgram
    {
        public void Test()
        {
            var originalPrice = 100.0m;

            var discountStrategy = DiscountFactory.CreateDiscountStrategy("seasonal");
            Console.WriteLine($"Seasonal Discounted Price: {discountStrategy.ApplyDiscount(originalPrice)}");

            discountStrategy = DiscountFactory.CreateDiscountStrategy("clearance");
            Console.WriteLine($"Clearance Discounted Price: {discountStrategy.ApplyDiscount(originalPrice)}");

            discountStrategy = DiscountFactory.CreateDiscountStrategy("member");
            Console.WriteLine($"Member Discounted Price: {discountStrategy.ApplyDiscount(originalPrice)}");
        }
    }
}
