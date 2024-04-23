﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory
{
    public class WithoutFactoryProgram
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
                return 150000;
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
                return 250000;
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
                return 350000;
            }

            public int GetAnnualCharge()
            {
                return 2000;
            }
        }

        public void Test()
        {
            // Generally we will get the Card Type from UI.
            // Here we are hardcoded the card type
            var cardType = "MoneyBack";

            ICreditCard creditCard = null;

            // Based of the CreditCard Type we are creating the
            // appropriate type instance using if else condition
            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new Platinum();
            }

            if (creditCard != null)
            {
                Console.WriteLine("CardType : " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}