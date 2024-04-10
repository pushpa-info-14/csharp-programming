namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class PayPalTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via PayPal...");
            return true; // Mocked success
        }
    }
}
