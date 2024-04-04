namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without
{
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
}
