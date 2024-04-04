namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DesigningASystemForABank
{
    public class SavingsAccount : IAccount
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} to Savings Account. New Balance: {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            // Implement logic specific to Savings account (e.g., limited withdrawals, minimum balance requirement)
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from Savings Account. New Balance: {Balance}");
        }
    }
}
