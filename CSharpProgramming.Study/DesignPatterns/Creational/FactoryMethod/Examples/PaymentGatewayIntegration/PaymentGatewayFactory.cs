namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public abstract class PaymentGatewayFactory
    {
        public abstract IPaymentGateway CreatePaymentGateway();
    }
}
