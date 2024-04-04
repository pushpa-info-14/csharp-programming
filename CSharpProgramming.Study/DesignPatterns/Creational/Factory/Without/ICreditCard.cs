namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
