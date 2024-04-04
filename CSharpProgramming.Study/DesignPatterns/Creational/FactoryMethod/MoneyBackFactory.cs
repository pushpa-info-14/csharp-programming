﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod
{
    // MoneyBackFactory Concrete Creators override the factory MakeProduct method
    // to create and return the MoneyBack Product
    public class MoneyBackFactory : CreditCardFactory
    {
        // The signature of the method still uses the abstract product CreditCard type
        // Even though the concrete MoneyBack product is actually returned from the method.
        // This way the Creator can stay independent of concrete product classes.
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }
}
