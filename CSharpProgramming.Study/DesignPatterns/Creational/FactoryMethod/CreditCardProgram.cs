namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardProgram
    {
        public void Test()
        {
            // The client code works with an instance of a concrete creator
            // The CreateProduct will return the actual product instance via the product interface
            // PlatinumFactory CreateProduct method will return an instance of Platinum Product via the ICreditCard interface
            var creditCard = new PlatinumFactory().CreateProduct();

            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            Console.WriteLine("--------------");

            // MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the ICreditCard interface
            creditCard = new MoneyBackFactory().CreateProduct();

            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            Console.WriteLine("--------------");

            // TitaniumFactory CreateProduct method will return an instance of Titanium Product via the ICreditCard interface
            creditCard = new TitaniumFactory().CreateProduct();

            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
    }
}
