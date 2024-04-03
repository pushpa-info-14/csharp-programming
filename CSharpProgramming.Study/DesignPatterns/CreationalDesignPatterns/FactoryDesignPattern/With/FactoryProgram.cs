using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Without;

namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.With
{
    public class FactoryProgram
    {
        public void Test()
        {
            ICreditCard? creditCard = CreditCardFactory.GetCreditCard("Platinum");

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
