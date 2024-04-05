namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class CreditCardPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of amount: ${amount}");
            // Actual logic to process credit card payment...
        }
    }
}
