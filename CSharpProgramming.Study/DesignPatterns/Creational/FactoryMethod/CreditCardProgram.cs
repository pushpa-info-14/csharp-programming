namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod
{
    public class CreditCardProgram
    {
        public interface ICreditCard
        {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }

        public class MoneyBack : ICreditCard
        {
            public string GetCardType()
            {
                return "MoneyBack";
            }
            public int GetCreditLimit()
            {
                return 15000;
            }
            public int GetAnnualCharge()
            {
                return 500;
            }
        }

        public class Titanium : ICreditCard
        {
            public string GetCardType()
            {
                return "Titanium Edge";
            }
            public int GetCreditLimit()
            {
                return 25000;
            }
            public int GetAnnualCharge()
            {
                return 1500;
            }
        }

        public class Platinum : ICreditCard
        {
            public string GetCardType()
            {
                return "Platinum Plus";
            }
            public int GetCreditLimit()
            {
                return 35000;
            }
            public int GetAnnualCharge()
            {
                return 2000;
            }
        }

        // The CreditCardFactory Creator class declares the factory method 
        // that is going to return an object of a Product class. 
        // The CreditCardFactory subclasses usually provide the implementation of the MakeProduct method.
        public abstract class CreditCardFactory
        {
            protected abstract ICreditCard MakeProduct();
            // Also note that The Creator's primary responsibility is not creating products. 
            // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
            public ICreditCard CreateProduct()
            {
                // Call the MakeProduct which will create and return the appropriate object 
                ICreditCard creditCard = MakeProduct();
                // Return the Object to the Client
                return creditCard;
            }
        }

        // PlatinumFactory Concrete Creators override the factory MakeProduct method
        // to create and return the Platinum Product
        public class PlatinumFactory : CreditCardFactory
        {
            // The signature of the method uses the abstract product CreditCard type,
            // Even though the concrete Platinum product is returned from the method.
            // This way the Abstract Creator CreditCardFactory can stay independent of concrete product classes.
            protected override ICreditCard MakeProduct()
            {
                return new Platinum();
            }
        }

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

        // TitaniumFactory Concrete Creators override the factory MakeProduct method
        // to create and return the Platinum Product
        public class TitaniumFactory : CreditCardFactory
        {
            // The signature of the method uses the abstract product CreditCard type,
            // Even though the concrete Titanium product is returned from the method.
            // This way the Abstract Creator CreditCardFactory can stay independent of concrete product classes.
            protected override ICreditCard MakeProduct()
            {
                return new Titanium();
            }
        }

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
