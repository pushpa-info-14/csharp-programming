namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class PayPalAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via PayPal...");
            return true; // Mocked success
        }
    }
}
