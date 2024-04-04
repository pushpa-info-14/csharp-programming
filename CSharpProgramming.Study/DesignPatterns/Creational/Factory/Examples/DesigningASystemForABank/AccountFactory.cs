namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DesigningASystemForABank
{
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
}
