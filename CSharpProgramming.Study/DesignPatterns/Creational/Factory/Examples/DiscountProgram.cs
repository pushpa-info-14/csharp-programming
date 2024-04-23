namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples
{
    public class DiscountProgram
    {
        public interface IDiscountStrategy
        {
            decimal ApplyDiscount(decimal price);
        }

        public class MemberDiscount : IDiscountStrategy
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price * 0.95m; // 5% member discount
            }
        }

        public class SeasonalDiscount : IDiscountStrategy
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price * 0.90m; // 10% seasonal discount
            }
        }

        public class ClearanceDiscount : IDiscountStrategy
        {
            public decimal ApplyDiscount(decimal price)
            {
                return price * 0.70m; // 30% clearance discount
            }
        }

        public static class DiscountFactory
        {
            public static IDiscountStrategy CreateDiscountStrategy(string type)
            {
                switch (type.ToLower())
                {
                    case "seasonal":
                        return new SeasonalDiscount();
                    case "clearance":
                        return new ClearanceDiscount();
                    case "member":
                        return new MemberDiscount();
                    default:
                        throw new ArgumentException("Invalid discount type");
                }
            }
        }

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
