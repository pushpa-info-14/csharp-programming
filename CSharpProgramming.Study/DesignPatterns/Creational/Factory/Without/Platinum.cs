namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without
{
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
}
