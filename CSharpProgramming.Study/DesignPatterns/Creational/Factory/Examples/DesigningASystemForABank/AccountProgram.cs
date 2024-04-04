namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DesigningASystemForABank
{
    public class AccountProgram
    {
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
