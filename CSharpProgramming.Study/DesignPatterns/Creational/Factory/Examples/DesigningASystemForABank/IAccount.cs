namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DesigningASystemForABank
{
    public interface IAccount
    {
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
