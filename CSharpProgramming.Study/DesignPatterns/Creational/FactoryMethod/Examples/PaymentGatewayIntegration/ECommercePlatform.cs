namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class ECommercePlatform
    {
        public void Checkout(PaymentGatewayFactory factory, decimal amount)
        {
            IPaymentGateway paymentGateway = factory.CreatePaymentGateway();
            paymentGateway.ProcessPayment(amount);
        }
    }
}
