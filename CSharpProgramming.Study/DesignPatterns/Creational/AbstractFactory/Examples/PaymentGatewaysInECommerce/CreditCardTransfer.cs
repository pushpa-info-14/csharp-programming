namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class CreditCardTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via Credit Card...");
            return true; // Mocked success
        }
    }
}
