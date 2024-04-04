namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.PaymentGatewayIntegration
{
    public class PaymentGatewayProgram
    {
        public void Test()
        {
            Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
            var paymentGateways = new string[] { "PayPal", "Stripe", "CreditCard" };
            var gatewayName = paymentGateways[new Random().Next(0, paymentGateways.Length)];

            try
            {
                IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                paymentGateway.ProcessPayment(100.00M);  // Example amount
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
