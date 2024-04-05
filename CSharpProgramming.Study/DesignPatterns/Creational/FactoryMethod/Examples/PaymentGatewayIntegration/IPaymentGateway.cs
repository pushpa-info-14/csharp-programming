namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
