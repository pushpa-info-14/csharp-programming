﻿namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DiscountsInAnECommerceApplication
{
    internal class SeasonalDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.90m; // 10% seasonal discount
        }
    }
}
