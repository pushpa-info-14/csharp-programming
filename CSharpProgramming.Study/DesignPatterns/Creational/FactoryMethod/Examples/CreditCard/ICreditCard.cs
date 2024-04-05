namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.CreditCard
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
