namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DesigningASystemForABank
{
    public class FixedDepositAccount : IAccount
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            // Typically, you can't deposit into a fixed deposit account once it's created. For simplicity, we'll allow it here.
            Balance += amount;
            Console.WriteLine($"Deposited {amount} to Fixed Deposit Account. New Balance: {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            // Implement logic specific to Fixed Deposit account (e.g., penalties for early withdrawal)
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from Fixed Deposit Account with penalty. New Balance: {Balance}");
        }
    }
}
