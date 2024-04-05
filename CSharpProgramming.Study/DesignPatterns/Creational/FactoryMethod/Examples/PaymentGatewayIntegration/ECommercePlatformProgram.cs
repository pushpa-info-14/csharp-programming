namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class ECommercePlatformProgram
    {
        public void Test()
        {
            var platform = new ECommercePlatform();

            // User selects Credit Card as the payment method:
            platform.Checkout(new CreditCardPaymentGatewayFactory(), 100.50M);

            // User selects PayPal as the payment method:
            platform.Checkout(new PayPalPaymentGatewayFactory(), 150.75M);

            // User selects Bitcoin as the payment method:
            platform.Checkout(new BitcoinPaymentGatewayFactory(), 50.30M);
        }
    }
}
