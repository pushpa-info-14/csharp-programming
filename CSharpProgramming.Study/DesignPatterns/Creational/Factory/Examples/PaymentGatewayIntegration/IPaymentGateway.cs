namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.PaymentGatewayIntegration
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
