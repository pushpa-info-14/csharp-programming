using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Without;

namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.With
{
    public static class CreditCardFactory
    {
        public static ICreditCard? GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;

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

            return creditCard;
        }
    }
}
