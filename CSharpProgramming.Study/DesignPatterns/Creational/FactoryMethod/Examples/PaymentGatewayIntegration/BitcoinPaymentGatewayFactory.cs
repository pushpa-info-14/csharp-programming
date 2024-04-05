namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public class BitcoinPaymentGatewayFactory : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway()
        {
            return new BitcoinPaymentGateway();
        }
    }
}
