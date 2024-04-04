namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication
{
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
}
