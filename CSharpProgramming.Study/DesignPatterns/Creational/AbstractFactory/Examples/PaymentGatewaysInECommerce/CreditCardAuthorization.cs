namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class CreditCardAuthorization : IPaymentAuthorization
    {
        public bool AuthorizePayment(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via Credit Card...");
            return true; // Mocked success
        }
    }
}
