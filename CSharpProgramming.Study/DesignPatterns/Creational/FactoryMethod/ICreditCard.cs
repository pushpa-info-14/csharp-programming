namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
