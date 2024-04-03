namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Without
{
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
}
