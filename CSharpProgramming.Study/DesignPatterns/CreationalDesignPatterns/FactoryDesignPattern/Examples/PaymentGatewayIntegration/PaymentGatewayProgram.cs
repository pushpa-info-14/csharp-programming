namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.PaymentGatewayIntegration
{
    public class PaymentGatewayProgram
    {
        public void Test()
        {
            var paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("PayPal");
            paymentGateway.ProcessPayment(100.00M);  // Example amount

            paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("Stripe");
            paymentGateway.ProcessPayment(100.00M);  // Example amount

            paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("CreditCard");
            paymentGateway.ProcessPayment(100.00M);  // Example amount
        }
    }
}
