namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class PayPalPaymentGatewayFactory : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new PayPalPaymentGateway();
        }
    }
}
