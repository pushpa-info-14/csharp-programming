namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DesigningASystemForABank
{
    public interface IAccount
    {
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
