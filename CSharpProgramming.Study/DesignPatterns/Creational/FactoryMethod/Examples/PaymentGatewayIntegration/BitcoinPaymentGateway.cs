namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class BitcoinPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of amount: ${amount}");
            // Actual logic to process Bitcoin payment...
        }
    }
}
