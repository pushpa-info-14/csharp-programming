namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without
{
    public class WithoutFactoryProgram
    {
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