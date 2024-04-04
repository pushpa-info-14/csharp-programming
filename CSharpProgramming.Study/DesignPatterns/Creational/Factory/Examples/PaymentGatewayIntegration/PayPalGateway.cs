namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.PaymentGatewayIntegration
{
    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment through PayPal...");
            // Actual integration and logic for PayPal
        }
    }
}
