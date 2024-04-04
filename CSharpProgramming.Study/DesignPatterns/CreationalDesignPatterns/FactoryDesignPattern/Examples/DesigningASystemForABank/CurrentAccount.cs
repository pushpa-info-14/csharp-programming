namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.DesigningASystemForABank
{
    public class CurrentAccount : IAccount
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} to Current Account. New Balance: {Balance}");
        }
        public void Withdraw(decimal amount)
        {
            // Implement logic specific to Current account (e.g., no withdrawal limit)
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} from Current Account. New Balance: {Balance}");
        }
    }
}
