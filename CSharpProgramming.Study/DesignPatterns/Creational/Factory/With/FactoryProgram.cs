using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without;

namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.With
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
