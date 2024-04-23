namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples
{
    public class AccountProgram
    {
        public interface IAccount
        {
            decimal Balance { get; }
            void Deposit(decimal amount);
            void Withdraw(decimal amount);
        }

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

        public static class AccountFactory
        {
            public static IAccount CreateAccount(string accountType)
            {
                switch (accountType.ToLower())
                {
                    case "savings":
                        return new SavingsAccount();
                    case "current":
                        return new CurrentAccount();
                    case "fixeddeposit":
                        return new FixedDepositAccount();
                    default:
                        throw new ArgumentException("Invalid account type");
                }
            }
        }

        public void Test()
        {
            var account = AccountFactory.CreateAccount("savings");
            account.Deposit(1000);   // Sample operation to show account creation.

            account = AccountFactory.CreateAccount("current");
            account.Deposit(1000);   // Sample operation to show account creation.

            account = AccountFactory.CreateAccount("fixeddeposit");
            account.Deposit(1000);   // Sample operation to show account creation.
        }
    }
}
