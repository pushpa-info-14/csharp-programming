namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class CreditCardPaymentGatewayFactory : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new CreditCardPaymentGateway();
        }
    }
}
